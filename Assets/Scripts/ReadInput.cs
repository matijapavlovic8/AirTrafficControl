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

    //GameObject Ant_Smashed = GameObject.Find("Dropdown1");

    private int n;
    private GameObject airport;
    public GameObject obj;

    // Start is called before the first frame update


    /*void Awake() {
        obj = GameObject.FindGameObjectWithTag("Dropdown 1");

    }*/
    void Start()
    {
<<<<<<< HEAD
=======
        //input = obj.GetComponent<Dropdown1> ().num;
        plane = GameObject.Find("Plane");
>>>>>>> 4ccd35e09fce222edc4e1dbbb422b34c7c711ba1
        n = UnityEngine.Random.Range(1, 3);
        airport = GameObject.Find("Airport " + n);
        body = plane.GetComponent<Rigidbody2D>();
        ReadStringInput("90");
        
    }

    // Update is called once per frame
    void Update()
    {

        if (input == 0)
            plane.transform.position = Vector2.MoveTowards(plane.transform.position, airport.transform.position, speed);
        else
        {
            body.velocity = Vector2.zero;
<<<<<<< HEAD
            plane.transform.position = Vector2.MoveTowards(plane.transform.position, position, speed);
=======
            plane.transform.position = Vector2.MoveTowards(plane.transform.position, position, .001f);
            plane.transform.Translate(position * Time.deltaTime, Space.World);
>>>>>>> 4ccd35e09fce222edc4e1dbbb422b34c7c711ba1
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
