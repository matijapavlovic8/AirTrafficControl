using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetPanel : MonoBehaviour
{

    [SerializeField] GameObject panel;
    private bool f = false;

    private void OnMouseDown()
    {
        f = !f;
        panel.SetActive(f);
    }
}
