using UnityEngine;

public class OnCollision : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject != gameObject)
        {
            Debug.Log("Kolizija");
        }
    }
}
