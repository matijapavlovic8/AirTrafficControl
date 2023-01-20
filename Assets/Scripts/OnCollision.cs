using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;



public class OnCollision : MonoBehaviour
{

    public string str_directory = Environment.CurrentDirectory.ToString();

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject != gameObject)
        {
             using (StreamWriter writer = new StreamWriter("Wfile.txt"));
             {
                 string parent = System.IO.Directory.GetParent(str_directory).FullName;
                Debug.Log(parent);
                string file = @parent + "/AirTrafficControl/log.txt";
                Vector3 sudar = collision.transform.position;
                string sudarString = sudar.ToString();
                Debug.Log(sudarString);
                string s = "dogodio se sudar";
                string ispis = "Koordinate sudara su:";
                string[] tekst = {ispis, sudarString};
                File.WriteAllLines(file, tekst);
             }
            Debug.Log("Kolizija");
        }
    }
}

