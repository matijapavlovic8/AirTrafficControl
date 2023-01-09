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
    // Start is called before the first frame update
    public TMP_Dropdown dr2;
    public TMP_Dropdown dropdown;
    public Vector2 position;
    private int input;
    private float speed = 0.001f;
    private GameObject airport;
    private int n;
    private float moveX;
    private float moveY;
    private string a;

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

    public void ReadFirstInput()
    {
        //var dropdown = transform.GetComponents<TMP_Dropdown>();

        //TMP_Dropdown dropdown = gameObject.GetComponent<TMP_Dropdown>();



        List<string> items = new List<string>();
        List<string> items2 = new List<string>();
        items.Add("0");
        items.Add("1");
        items.Add("2");
        items.Add("3");
        dropdown.options.Clear();

        foreach (var item in items)
        {
            dropdown.options.Add(new TMP_Dropdown.OptionData() { text = item });

        }

        a = dropdown.options[dropdown.value].text;
        //print("1121" + a);

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
        else if (a == "1" | a == "2")
        {
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
        }
        else
        {
            items2.Add("00");
            items2.Add("10");
            items2.Add("20");
            items2.Add("30");
            items2.Add("40");
            items2.Add("50");
            items2.Add("60");
        }
        foreach (var item in items2)
        {
            dr2.options.Add(new TMP_Dropdown.OptionData() { text = item });

        }
    }
    public void ReadSecondInput()
    {

        input = Int32.Parse(a + dr2.options[dr2.value].text);
        print(input);
        moveX = (float)Math.Sin((Math.PI / 180) * input);
        moveY = (float)Math.Cos((Math.PI / 180) * input);
        position = new Vector2(moveX * 1000, moveY * 1000);
        print(position);
        Debug.Log(position);
    }

    string DropdpownItemSelectedString(TMP_Dropdown dropdown)
    {
        int index = dropdown.value;

        return dropdown.options[index].text;
    }


}