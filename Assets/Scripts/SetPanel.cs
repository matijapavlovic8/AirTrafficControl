using TMPro;
using UnityEngine;
using System.IO;
using System;


public class SetPanel : MonoBehaviour
{

    public string str_directory = Environment.CurrentDirectory.ToString();


    [SerializeField] GameObject panel;
    [SerializeField] TMP_Dropdown dr1;
    [SerializeField] TMP_Dropdown dr2;
    [SerializeField] TMP_Dropdown dr3;
    [SerializeField] Dropdown1 dropdown1;
    private bool f = false;

    private void OnMouseDown()
    {
         using (StreamWriter writer = new StreamWriter("Wfile.txt"));
             {

                 string sudarString = transform.position.ToString();
                string parent = System.IO.Directory.GetParent(str_directory).FullName;
                Debug.Log(parent);
                 string file = @parent + "/AirTrafficControl/log.txt";
                //Debug.Log(plane.tag);
                string ispis = "Kliknuli ste na avion koji kontrolirate";
                string[] tekst = {ispis};
                File.WriteAllLines(file, tekst);
             }
        f = !f;
        panel.SetActive(f);
        dropdown1.plane = PlaneFlight.getByPlane(gameObject);
    }
}
