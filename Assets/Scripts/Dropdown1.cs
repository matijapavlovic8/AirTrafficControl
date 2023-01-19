using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
public class Dropdown1 : MonoBehaviour
{

    [SerializeField] GameObject plane;
    private Rigidbody2D body;

    public TMP_Text TextBox;
    public string selectedOption;
    public TMP_Dropdown dr2;
    public TMP_Dropdown dr3;
    public TMP_Dropdown dropdown;
    public Vector2 position;
    private int input;
    private float speed = 1f;
    private float turnSpeed = 50f;
    private GameObject airport;
    private int n;
    private float moveX;
    private float moveY;
    private string a;

    private int direction = 1;
    private bool isRotating = false;
    private float angle;

    public void setPlane(GameObject p)
    {
        plane = p;
    }

    void Start()
    {
        n = UnityEngine.Random.Range(1, 5);
        airport = GameObject.Find("Airport " + n);
        body = plane.GetComponent<Rigidbody2D>();

        Vector3 targ = airport.transform.position;
        plane.transform.up = targ - plane.transform.position;
    }

    void Update()
    {
        
        if (input == 0)
        {
            body.MovePosition(Vector2.MoveTowards(plane.transform.position, airport.transform.position, speed * Time.deltaTime));
            angle = -body.rotation;
            if (angle < 0)
                angle += 360;
        }
        else
        {
            
            if(isRotating)
            {
                if(direction == 1)
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
                plane.transform.up = forceVector - (Vector2)plane.transform.position;

                body.MovePosition(Vector2.MoveTowards(plane.transform.position, forceVector, speed * Time.deltaTime));

                if (Mathf.Abs(angle - input) < 10f)
                {
                    angle = input;
                    isRotating = false;
                }
                
            }
            else
            {
                plane.transform.up = position - (Vector2)plane.transform.position;
                body.MovePosition(Vector2.MoveTowards(plane.transform.position, position, speed * Time.deltaTime));
            }
        }
        
    }

    public void ReadFirstInput() {
        //var dropdown = transform.GetComponents<TMP_Dropdown>();
        
        //TMP_Dropdown dropdown = gameObject.GetComponent<TMP_Dropdown>();
        
        

        List<string> items = new List<string>();
        List<string> items2 = new List<string>();
        items.Add("0");
        items.Add("1");
        items.Add("2");
        items.Add("3");
        dropdown.options.Clear();

        foreach(var item in items) {
            dropdown.options.Add(new TMP_Dropdown.OptionData() {text = item});
        }

        a = dropdown.options[dropdown.value].text;
            
            selectedOption = DropdpownItemSelectedString(dropdown);
            a = dropdown.options[dropdown.value].text;
            
            dr2.options.Clear();
            items2.Clear();
            if (a == "0")
            {
                items2.Add("10");
                items2.Add("20");
                items2.Add("30");
                items2.Add("40");
                items2.Add("50");
                items2.Add("60");
                items2.Add("70");
                items2.Add("80");
                items2.Add("90");
        }
            else if (a == "1" || a == "2"){
                items2.Add("00");
                items2.Add("10");
                items2.Add("20");
                items2.Add("30");
                items2.Add("40");
                items2.Add("50");
                items2.Add("60");
                items2.Add("70");
                items2.Add("80");
                items2.Add("90");
            } else {
                items2.Add("00");
                items2.Add("10");
                items2.Add("20");
                items2.Add("30");
                items2.Add("40");
                items2.Add("50");
                items2.Add("60");
            }
            foreach(var item in items2) {
            dr2.options.Add(new TMP_Dropdown.OptionData() {text = item});

        }
    }
    public void ReadSecondInput() {

        input = Int32.Parse(a + dr2.options[dr2.value].text);
        if (dr3.options[dr3.value].text.Equals("R"))
        {
            direction = 1;
        }
        else
        {
            direction = -1;
        }
        moveX = (float) Math.Sin((Math.PI / 180) * input);
        moveY = (float) Math.Cos((Math.PI / 180) * input);
        position = new Vector2(moveX * 1000, moveY * 1000);
        isRotating = true;
    }

    string DropdpownItemSelectedString(TMP_Dropdown dropdown) {
        int index = dropdown.value;

        return dropdown.options[index].text;
    }

   
}