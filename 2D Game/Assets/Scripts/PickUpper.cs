using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpper : MonoBehaviour {

    public InventoryManager inv;
    public GameObject itemPick;


    public void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            //col.gameObject.GetComponent<InventoryManager>().playerInv.Add(gameObject);
            for (int i = 0; i < inv.playerInv.Count; i++)
            {
                if (inv.playerInv[i].transform.childCount == 0)
                {
                    Instantiate(itemPick, inv.playerInv[i].transform.position, Quaternion.identity).transform.SetParent(inv.playerInv[i].transform);
                    break;
                }

                else
                {
                    Destroy(gameObject);
                }
            }

        }
    }
}
