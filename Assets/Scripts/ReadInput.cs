using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{

    private GameObject plane;
    private int input;
    private float moveX;
    private float moveY;
    private float move;
    private float rotation;
    private Vector2 position;

    // Start is called before the first frame update
    void Start()
    {
        plane = GameObject.Find("Plane");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput(string s)
    {
        input = Int32.Parse(s);
        moveX = (float) Math.Sin((Math.PI / 180) * input) * Time.deltaTime * .5f;
        moveY = (float) Math.Cos((Math.PI / 180) * input) * Time.deltaTime * .5f;
        position = new Vector2(moveX, moveY);
        //move = (float) moveY * Time.deltaTime * 1f;
        //rotation = (float) moveX * Time.deltaTime * -20f;
        Debug.Log(moveX + " " + moveY);
    }

    private void LateUpdate()
    {
        //plane.transform.Translate(moveX, moveY, 0f);
        //plane.transform.position = Vector2.MoveTowards(plane.transform.position, position, 0f);
        //plane.transform.Rotate(0f, 0f, rotation);
    }
}
