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
     private float turnSpeed = 500f;
     private GameObject airport;
     private int n;
     private float moveX;
     private float moveY;
     private string a;
     private int direction = 1;

    private float force = 0.25f;

    void Start()
    {
        n = UnityEngine.Random.Range(1, 5);
        airport = GameObject.Find("Airport " + n);
        body = plane.GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        
        if (input == 0)
        {

            //plane.transform.position = Vector2.MoveTowards(plane.transform.position, airport.transform.position, speed);
            //Vector3 targ = airport.transform.position;
            //plane.transform.up = targ - plane.transform.position;

            Vector2 dir = ((Vector2)airport.transform.position - (Vector2)plane.transform.position).normalized * 1000;

            body.MovePosition(Vector2.MoveTowards(plane.transform.position, airport.transform.position, speed * Time.deltaTime));

            float currentAngle = body.rotation;
            float targerAngle = -1 * Mathf.Atan2(dir.x, dir.y) * Mathf.Rad2Deg;
            float newAngle = Mathf.MoveTowardsAngle(currentAngle, targerAngle, turnSpeed * Time.deltaTime);

            body.MoveRotation(newAngle);

            //Vector2 forceVector = Quaternion.Euler(0, 0, -body.rotation) * -dir / 100 * force;
            //body.AddForce(forceVector);
        }
        else
        {

            body.MovePosition(Vector2.MoveTowards(plane.transform.position, position, speed * Time.deltaTime));

            float currentAngle = body.rotation;
            float targerAngle = -1 * Mathf.Atan2(position.x, position.y) * Mathf.Rad2Deg;
            float newAngle = Mathf.MoveTowardsAngle(currentAngle, targerAngle, turnSpeed * Time.deltaTime);

            body.MoveRotation(newAngle);

            //Vector2 forceVector = Quaternion.Euler(0, 0, -body.rotation) * -position / 100 * force;
            //body.AddForce(forceVector);
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
        //print("1121" + a);
            
            selectedOption = DropdpownItemSelectedString(dropdown);
            a = dropdown.options[dropdown.value].text;
            

            dr2.options.Clear();
            items2.Clear();
            if (a == "0" || a == "1" || a == "2"){
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
    }

    string DropdpownItemSelectedString(TMP_Dropdown dropdown) {
        int index = dropdown.value;

        return dropdown.options[index].text;
    }

   
}