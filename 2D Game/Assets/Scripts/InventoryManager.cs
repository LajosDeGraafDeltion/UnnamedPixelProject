using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryManager : MonoBehaviour {

    public Transform selectedSlot, originalSlot;
    public GameObject selectedItem;
    public Image test;
    public Image currentIcon;
    public List<GameObject> playerInv = new List<GameObject>();
    public static bool selected;

    public GameObject toolTipName;
    public GameObject toolTipDesc;
    public GameObject toolTipValue;
    public GameObject toolTipWeight;
    public GameObject toolTipUI;

    private void Start()
    {
        currentIcon.enabled = false;
        toolTipUI.SetActive(false);
        
    }

    public void Update()
    {

        currentIcon.transform.position = Input.mousePosition;

        if (Input.GetMouseButtonDown(0) && selectedItem != null && test == null)
        {
            test =  selectedItem.GetComponent<Image>();

            currentIcon.sprite = test.sprite;
            print(currentIcon);
            test.enabled = false;
            currentIcon.enabled = true;
            selected = true;
        }
        if (Input.GetMouseButton(0) && selectedItem != null && test == null)
        {
            selectedItem.transform.position = Input.mousePosition;
            //Zodra test gevuld is mag selectedItem niet vullen;

        }
        else if (Input.GetMouseButtonUp(0) && selectedItem != null)
        {
            selectedItem.transform.SetParent(selectedSlot, false);
            selectedItem.transform.localPosition = Vector3.zero;
            test.enabled = true;
            currentIcon.enabled = false;
            selectedItem = null;
            selected = false;
            test = null;
        }

        if (selectedItem != null)
        {
            toolTipUI.SetActive(true);
            toolTipName.GetComponent<Text>().text = selectedItem.GetComponent<Item>().itemName;
            toolTipDesc.GetComponent<Text>().text = selectedItem.GetComponent<Item>().itemDesc;
            toolTipValue.GetComponent<Text>().text = selectedItem.GetComponent<Item>().itemValue.ToString();
            toolTipWeight.GetComponent<Text>().text = selectedItem.GetComponent<Item>().itemWeight.ToString();
        }
        else
        {
            toolTipUI.SetActive(false);
        }
    }

    public void ExitItem()
    {
        if (selected == false)
        {
            selectedItem = null;
        }
    }

}
