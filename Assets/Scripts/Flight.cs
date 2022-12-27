using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Flight : MonoBehaviour
{
    private int n;
    private GameObject airport;

    // Start is called before the first frame update
    void Start()
    {
        n = Random.Range(1, 3);
        airport = GameObject.Find("Airport " + n);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, airport.transform.position, .003f);
    }
}
