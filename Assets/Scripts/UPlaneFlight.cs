using System.Collections;
using UnityEngine;
using UnityEngine.UIElements;

public class UPlaneFlight : MonoBehaviour
{
    private Rigidbody2D body;
    private float speed = 1f;
    private float x, y;
    private Vector2 position;

    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        x = -transform.position.x;
        y = -transform.position.y;
        position = new Vector2(x * 1000, y * 1000);
        transform.up = position - (Vector2)transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        body.MovePosition(Vector2.MoveTowards(transform.position, position, speed * Time.deltaTime));
    }
}
