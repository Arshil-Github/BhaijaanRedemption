using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assigner : MonoBehaviour
{
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)
        {
            LeftMovers lm = child.gameObject.AddComponent<LeftMovers>();
            lm.speed = speed;

            child.gameObject.AddComponent<DestroyOnWall>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
