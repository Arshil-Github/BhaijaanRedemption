using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnWall : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }
    }
}
