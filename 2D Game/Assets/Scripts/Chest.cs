using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour {

    public Transform currentItem;

    public void OnTriggerEnter2D(Collider2D c)
    {
        if (c.gameObject.tag == "Player" && Input.GetButtonDown("E"))
        {
            print("Pressed E");
            Instantiate(currentItem, new Vector3(2.0F, 0, 0), Quaternion.identity);
        }
    }
}
