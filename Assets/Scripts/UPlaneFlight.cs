using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UPlaneFlight : MonoBehaviour
{
    [SerializeField] GameObject airport1;
    [SerializeField] GameObject airport2;
    [SerializeField] GameObject airport3;
    private Rigidbody2D body;
    private List<GameObject> airports = new List<GameObject>();
    private float speed = 0.001f;
    private bool f1 = true;
    private bool f2 = false;
    private bool f3 = false;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        airports.Add(airport1);
        airports.Add(airport2);
        airports.Add(airport3);
        airports.Sort((a, b) => 1 - 2 * Random.Range(0, 1));
}

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, airports[0].transform.position) > .001f && f1)
            transform.position = Vector2.MoveTowards(transform.position, airports[0].transform.position, speed);
        else if (Vector2.Distance(transform.position, airports[0].transform.position) <= .001f)
        {
            f1 = false;
            f2 = true;
        }

        if (Vector2.Distance(transform.position, airports[1].transform.position) > .001f && f2 && !f1)
            transform.position = Vector2.MoveTowards(transform.position, airports[1].transform.position, speed);
        else if (Vector2.Distance(transform.position, airports[1].transform.position) <= .001f)
        {
            f2 = false;
            f3 = true;
        }

        if (Vector2.Distance(transform.position, airports[2].transform.position) > .001f && f3 && !(f1 || f2))
            transform.position = Vector2.MoveTowards(transform.position, airports[2].transform.position, speed);
    }
}
