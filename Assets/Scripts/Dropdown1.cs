using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;
public class Dropdown1 : MonoBehaviour
{

    public TMP_Text TextBox;
    public string selectedOption;
    // Start is called before the first frame update
     public TMP_Dropdown dr2;
    void Start()
    {



        
        var dropdown = transform.GetComponents<TMP_Dropdown>();
        
        

        List<string> items = new List<string>();
        List<string> items2 = new List<string>();
        items.Add("0");
        items.Add("1");
        items.Add("2");
        items.Add("3");
        dropdown[0].options.Clear();

        foreach(var item in items) {
            dropdown[0].options.Add(new TMP_Dropdown.OptionData() {text = item});

        }

        DropdpownItemSelected(dropdown[0]);

        dropdown[0].onValueChanged.AddListener(delegate {
            DropdpownItemSelected(dropdown[0]);
            selectedOption = DropdpownItemSelectedString(dropdown[0]);
            

            dr2.options.Clear();
            items2.Clear();
            if(dropdown[0].options[dropdown[0].value].text == "0") {
               items2.Add("10");
                items2.Add("20");
                items2.Add("30");
                items2.Add("40");
                items2.Add("50");
                items2.Add("60");
                items2.Add("70");
                items2.Add("80");
                items2.Add("90");
            } else if (dropdown[0].options[dropdown[0].value].text == "1" | dropdown[0].options[dropdown[0].value].text == "2"){
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
        });

        
    }

    void DropdpownItemSelected(TMP_Dropdown dropdown) {
        int index = dropdown.value;

        TextBox.text = dropdown.options[index].text;
    }

    string DropdpownItemSelectedString(TMP_Dropdown dropdown) {
        int index = dropdown.value;

        return dropdown.options[index].text;
    }

   
}
