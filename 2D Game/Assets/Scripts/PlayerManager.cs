using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public float playerSpeed;
    public float jumpSpeed;
    public Rigidbody2D rbPlayer;
    public List<GameObject> playerInv = new List<GameObject>();

	void Start ()
    {
        
	}
	

	void Update ()
    {
		
	}

    public void FixedUpdate()
    {
        float moveH = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        float moveV = Input.GetAxis("Vertical") * playerSpeed * Time.deltaTime;

        transform.Translate(moveH, moveV, 0);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "pickup")
        {
            playerInv.Add(gameObject);
        }
    }
}
