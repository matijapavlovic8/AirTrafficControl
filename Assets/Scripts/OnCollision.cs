using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Plane 1") || collision.gameObject.CompareTag("Plane 2") || collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("Kolizija");
        }
        Debug.Log("Kolizija");
    }
}
