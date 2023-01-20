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
    [SerializeField] GameObject plane1;
    [SerializeField] GameObject plane2;
    [SerializeField] GameObject plane3;
    [SerializeField] GameObject plane4;
    [SerializeField] GameObject plane5;
    [SerializeField] TextMeshProUGUI text2;
    [SerializeField] TextMeshProUGUI text3;
    [SerializeField] TextMeshProUGUI text4;
    [SerializeField] TextMeshProUGUI text5;

    private Vector2 planeStartPos, uPlaneStartPos;

    void Start()
    {
        planeStartPos = plane1.transform.position;
        uPlaneStartPos = plane5.transform.position;

        airport2.SetActive(false);
        airport3.SetActive(false);
        airport4.SetActive(false);
        airport5.SetActive(false);

        plane2.SetActive(false);
        plane3.SetActive(false);
        plane4.SetActive(false);

        text2.text = "";
        text2.text = "";
        text3.text = "";
        text4.text = "";
        text5.text = "";

        StartCoroutine(WaitBeforeShow());
    }

    private IEnumerator WaitBeforeShow() 
    {
        // cekanje 120 sekundi = 2 minute
        yield return new WaitForSeconds(120);

        airport2.SetActive(true);
        airport3.SetActive(true);
        airport4.SetActive(true);
        airport5.SetActive(true);

        plane2.SetActive(true);
        plane3.SetActive(true);
        plane4.SetActive(true);

        text2.text = "NAV2";
        text3.text = "NAV3";
        text4.text = "NAV4";
        text5.text = "NAV5";

        plane1.transform.position = planeStartPos;
        PlaneFlight.getByPlane(plane1).input = 0;
        plane5.transform.position = uPlaneStartPos;
    }

}
