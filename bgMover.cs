using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bgMover : MonoBehaviour
{
    public float speed;

    public float xToMove;
    public float xToSpawn;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void Update()
    {
        if(transform.position.x < xToMove)
        {
            transform.position = new Vector3(xToSpawn, transform.position.y, transform.position.z);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
    }
}
