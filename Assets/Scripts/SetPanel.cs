using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class SetPanel : MonoBehaviour
{

    [SerializeField] GameObject panel;
    [SerializeField] TMP_Dropdown dr1;
    [SerializeField] TMP_Dropdown dr2;
    [SerializeField] TMP_Dropdown dr3;
    private bool f = false;

    private void OnMouseDown()
    {
        f = !f;
        panel.SetActive(f);
        
    }
}
