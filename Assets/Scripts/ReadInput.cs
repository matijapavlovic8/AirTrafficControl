using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{

    [SerializeField] GameObject plane;
    private Rigidbody2D body;
    private int input;
    private float moveX;
    private float moveY;
    private Vector2 position;
    private float speed = 0.001f;

    private int n;
    private GameObject airport;

    // Start is called before the first frame update
    void Start()
    {
        n = UnityEngine.Random.Range(1, 3);
        airport = GameObject.Find("Airport " + n);
        body = plane.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (input == 0)
            plane.transform.position = Vector2.MoveTowards(plane.transform.position, airport.transform.position, speed);
        else
        {
            body.velocity = Vector2.zero;
            plane.transform.position = Vector2.MoveTowards(plane.transform.position, position, speed);
        }
    }

    public void ReadStringInput(string s)
    {
        input = Int32.Parse(s);
        moveX = (float) Math.Sin((Math.PI / 180) * input);
        moveY = (float) Math.Cos((Math.PI / 180) * input);
        position = new Vector2(moveX * 1000, moveY * 1000);
    }
}
