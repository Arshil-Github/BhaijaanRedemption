using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftMovers : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
    }
}
