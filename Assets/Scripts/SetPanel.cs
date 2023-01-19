using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPanel : MonoBehaviour
{

    [SerializeField] GameObject panel;
    private bool f = false;
    [SerializeField] Dropdown1 dropdown1;

    private void OnMouseDown()
    {
        f = !f;
        panel.SetActive(f);
        //dropdown1.setPlane(gameObject);
    }
}
