using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Diagnostics;
public class Dropdown2 : MonoBehaviour
{

    GameObject obj;
    public Dropdown1 first;


    void Awake()
    {
        obj = GameObject.FindGameObjectWithTag("Dropdown 1");
        
    }

    public TMP_Text TextBox;
    public string selectedOption;
    // Start is called before the first frame update
    void Start()
    {


                 System.Diagnostics.Debug.WriteLine("424242");

        
        var dropdown = transform.GetComponent<TMP_Dropdown>();
        string current = first.selectedOption;

        List<string> items = new List<string>();
        items.Add("10");
        items.Add("20");
        items.Add("30");
        items.Add("40");
        items.Add("50");
        items.Add("60");
        items.Add("70");
        items.Add("80");
        items.Add("90");

        dropdown.options.Clear();

        foreach(var item in items) {
            dropdown.options.Add(new TMP_Dropdown.OptionData() {text = item});

        }

        DropdpownItemSelected(dropdown);

        dropdown.onValueChanged.AddListener(delegate {
            DropdpownItemSelected(dropdown);
            selectedOption = DropdpownItemSelectedString(dropdown);
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
