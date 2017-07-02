using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public string itemName;
    public string itemDesc;
    public int itemID;
    public int itemValue;
    public float itemWeight;
    public Sprite itemIcon;

    public void OnMouseEnter()
    {
        if (InventoryManager.selected == false)
        {
            transform.parent.parent.GetComponent<InventoryManager>().selectedItem = gameObject;
        }
    }
}