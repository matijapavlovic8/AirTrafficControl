using System;
using UnityEngine;

public class PlaneFlight : MonoBehaviour
{
    private Rigidbody2D body;

    private float speed = 1f;
    private float turnSpeed = 50f;
    private GameObject airport;

    private int n;

    private float angle;

    public Vector2 position;
    public int input;
    public int direction;
    public bool isRotating;
    

    void Start()
    {
        n = UnityEngine.Random.Range(1, 5);
        if(GameObject.Find("Airport " + 2) == null)
        {
            airport = GameObject.Find("Airport " + 1);
        }
        else
        {
            airport = GameObject.Find("Airport " + n);
        }
        body = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (input == 0)
        {
            body.MovePosition(Vector2.MoveTowards(transform.position, airport.transform.position, speed * Time.deltaTime));
            Vector3 targ = airport.transform.position;
            transform.up = targ - transform.position;
            angle = -body.rotation;
            if (angle < 0)
                angle += 360;
        }
        else
        {
            if (isRotating)
            {
                if (direction == 1)
                {
                    angle += turnSpeed * Time.deltaTime;
                    if (angle >= 360)
                        angle -= 360;
                }
                else
                {
                    angle -= turnSpeed * Time.deltaTime;
                    if (angle <= 0)
                        angle += 360;
                }

                float x = (float)Math.Sin((Math.PI / 180) * angle);
                float y = (float)Math.Cos((Math.PI / 180) * angle);
                Vector2 forceVector = new Vector2(x * 1000, y * 1000);
                transform.up = forceVector - (Vector2)transform.position;

                body.MovePosition(Vector2.MoveTowards(transform.position, forceVector, speed * Time.deltaTime));

                if (Mathf.Abs(angle - input) < 10f)
                {
                    angle = input;
                    isRotating = false;
                }
            }
            else
            {
                transform.up = position - (Vector2)transform.position;
                body.MovePosition(Vector2.MoveTowards(transform.position, position, speed * Time.deltaTime));
            }
        }
    }

    public static PlaneFlight getByPlane(GameObject gameObject) { return gameObject.GetComponent<PlaneFlight>();}
}
