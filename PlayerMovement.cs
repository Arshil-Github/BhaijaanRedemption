using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpForceY;
    public float jumpForceX;
    public Animator anim;

    Manager manager;


    [HideInInspector]public bool canMove = false;

    Rigidbody2D rb;
    bool inAir = true;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        manager = GameObject.FindObjectOfType<Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        canMove = !canMove;
        if (canMove)
        {
            anim.SetBool("Running", true);
        }

        if (Input.GetKeyDown(KeyCode.Space) && inAir == false)
        {
            rb.AddForce(new Vector2(jumpForceX, jumpForceY), ForceMode2D.Impulse);
        }
    }
    private void FixedUpdate()
    {
        if (canMove)
        {
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        inAir = false;
        if (collision.gameObject.CompareTag("Catchee"))
        {
            manager.Win();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            manager.Lose();
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        inAir = true;
    }
}
