using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public bool invToggle;
    public Canvas uiInv;

    private void Start()
    {
        uiInv.enabled = false;
    }

    public void Update()
    {
        if (Input.GetButtonDown("E"))
        {
            uiInv.enabled = !uiInv.enabled;
        }
    }
}
