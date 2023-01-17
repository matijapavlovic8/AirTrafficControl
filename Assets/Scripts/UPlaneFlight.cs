using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UPlaneFlight : MonoBehaviour
{
    [SerializeField] GameObject airport1;
    [SerializeField] GameObject airport2;
    [SerializeField] GameObject airport3;
    [SerializeField] GameObject airport4;
    [SerializeField] GameObject airport5;
    private Rigidbody2D body;
    private List<GameObject> airports = new List<GameObject>();
    private float speed = 0.0005f;
    //private float turnSpeed = 0.001f;
    private bool f1 = true;
    private bool f2 = false;
    private bool f3 = false;
    private bool f4 = false;
    private bool f5 = false;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        airports.Add(airport1);
        airports.Add(airport2);
        airports.Add(airport3);
        airports.Add(airport4);
        airports.Add(airport5);
        airports.Sort((a, b) => 1 - 2 * Random.Range(0, 1));
}

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, airports[0].transform.position) > .001f && f1)
        {
            transform.position = Vector2.MoveTowards(transform.position, airports[0].transform.position, speed);
            Vector3 targ = airports[0].transform.position;
            transform.up = targ - transform.position;

            /*
            Vector2 dir = ((Vector2)airports[0].transform.position - (Vector2)transform.position).normalized * 1000;
            body.MovePosition(body.position + dir * speed * Time.deltaTime);
            float currentRotation = body.rotation;
            float targetRotation = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            body.MoveRotation(Mathf.LerpAngle(currentRotation, targetRotation, turnSpeed * Time.deltaTime));
            */
        }
        else if (Vector2.Distance(transform.position, airports[0].transform.position) <= .001f)
        {
            f1 = false;
            f2 = true;
        }

        if (Vector2.Distance(transform.position, airports[1].transform.position) > .001f && f2 && !f1)
        {
            transform.position = Vector2.MoveTowards(transform.position, airports[1].transform.position, speed);
            Vector3 targ = airports[1].transform.position;
            transform.up = targ - transform.position;

            /*
            Vector2 dir = ((Vector2)airports[1].transform.position - (Vector2)transform.position).normalized * 1000;
            body.MovePosition(body.position + dir * speed * Time.deltaTime);
            float currentRotation = body.rotation;
            float targetRotation = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            body.MoveRotation(Mathf.LerpAngle(currentRotation, targetRotation, turnSpeed * Time.deltaTime));
            */
        }  
        else if (Vector2.Distance(transform.position, airports[1].transform.position) <= .001f)
        {
            f2 = false;
            f3 = true;
        }

        if (Vector2.Distance(transform.position, airports[2].transform.position) > .001f && f3 && !(f1 || f2))
        {
            transform.position = Vector2.MoveTowards(transform.position, airports[2].transform.position, speed);
            Vector3 targ = airports[2].transform.position;
            transform.up = targ - transform.position;

            /*
            Vector2 dir = ((Vector2)airports[2].transform.position - (Vector2)transform.position).normalized * 1000;
            body.MovePosition(body.position + dir * speed * Time.deltaTime);
            float currentRotation = body.rotation;
            float targetRotation = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            body.MoveRotation(Mathf.LerpAngle(currentRotation, targetRotation, turnSpeed * Time.deltaTime));
            */
        } 
        else if (Vector2.Distance(transform.position, airports[2].transform.position) <= .001f)
        {
            f3 = false;
            f4 = true;
        }

        if (Vector2.Distance(transform.position, airports[3].transform.position) > .001f && f4 && !(f1 || f2 || f3))
        {
            transform.position = Vector2.MoveTowards(transform.position, airports[3].transform.position, speed);
            Vector3 targ = airports[3].transform.position;
            transform.up = targ - transform.position;

            /*
            Vector2 dir = ((Vector2)airports[3].transform.position - (Vector2)transform.position).normalized * 1000;
            body.MovePosition(body.position + dir * speed * Time.deltaTime);
            float currentRotation = body.rotation;
            float targetRotation = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            body.MoveRotation(Mathf.LerpAngle(currentRotation, targetRotation, turnSpeed * Time.deltaTime));
            */
        }
        else if (Vector2.Distance(transform.position, airports[3].transform.position) <= .001f)
        {
            f4 = false;
            f5 = true;
        }

        if (Vector2.Distance(transform.position, airports[4].transform.position) > .001f && f5 && !(f1 || f2 || f3 || f4))
        {
            transform.position = Vector2.MoveTowards(transform.position, airports[4].transform.position, speed);
            Vector3 targ = airports[4].transform.position;
            transform.up = targ - transform.position;

            /*
            Vector2 dir = ((Vector2)airports[4].transform.position - (Vector2)transform.position).normalized * 1000;
            body.MovePosition(body.position + dir * speed * Time.deltaTime);
            float currentRotation = body.rotation;
            float targetRotation = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            body.MoveRotation(Mathf.LerpAngle(currentRotation, targetRotation, turnSpeed * Time.deltaTime));
            */
        }
    }
}
