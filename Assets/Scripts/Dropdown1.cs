using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Dropdown1 : MonoBehaviour
{
    public TMP_Text TextBox;
    public string selectedOption;
    public TMP_Dropdown dr1;
    public TMP_Dropdown dr2;
    public TMP_Dropdown dr3;

    private Vector2 position;
    private int input;

    private float moveX;
    private float moveY;
    private string a;

    private int direction = 1;
    private bool isRotating = false;

    public PlaneFlight plane;

    public void ReadFirstInput() {
        List<string> items = new List<string>();
        List<string> items2 = new List<string>();
        items.Add("0");
        items.Add("1");
        items.Add("2");
        items.Add("3");
        dr1.options.Clear();

        foreach(var item in items) {
            dr1.options.Add(new TMP_Dropdown.OptionData() {text = item});
        }

        a = dr1.options[dr1.value].text;
            
        selectedOption = DropdpownItemSelectedString(dr1);
        a = dr1.options[dr1.value].text;
            
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

        plane.position = position;
        plane.input = input;
        plane.direction = direction;
        plane.isRotating = isRotating;
    }

    string DropdpownItemSelectedString(TMP_Dropdown dropdown) {
        int index = dropdown.value;
        return dropdown.options[index].text;
    }

}