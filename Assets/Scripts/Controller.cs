using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Controller : MonoBehaviour
{
    [SerializeField] GameObject airport2;
    [SerializeField] GameObject airport3;
    [SerializeField] GameObject airport4;
    [SerializeField] GameObject airport5;
    [SerializeField] GameObject plane2;
    [SerializeField] GameObject plane3;
    [SerializeField] GameObject plane4;
    [SerializeField] TextMeshProUGUI text2;
    [SerializeField] TextMeshProUGUI text3;
    [SerializeField] TextMeshProUGUI text4;
    [SerializeField] TextMeshProUGUI text5;

    void Start()
    {
        StartCoroutine(WaitBeforeShow());

        airport2.SetActive(true);
        airport3.SetActive(true);
        airport4.SetActive(true);
        airport5.SetActive(true);
        plane2.SetActive(true);
        plane2.GetComponent<UPlaneFlight>().enabled = true;
        plane3.SetActive(true);
        plane3.GetComponent<UPlaneFlight>().enabled = true;
        plane4.SetActive(true);
        plane4.GetComponent<PlaneFlight>().enabled = true;
        text2.text = "NAV2";
        text3.text = "NAV3";
        text4.text = "NAV4";
        text5.text = "NAV5";
    }

    private IEnumerator WaitBeforeShow() 
    {
        // cekanje 120 sekundi = 2 minute
        yield return new WaitForSeconds(5);
    }

}
