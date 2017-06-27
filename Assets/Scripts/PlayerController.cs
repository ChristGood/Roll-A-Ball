using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private float jump = 00.0f;
    private Rigidbody rb;
    private GameObject go;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        go = GameObject.Find("Player");
        
    }

    void FixedUpdate() {
        

        float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
        if ((go.transform.position.y*2) <= go.transform.localScale.y*1.1 && Input.GetKeyDown(KeyCode.Space))
        {
            jump = 20.0f;
        }
        else
        {
            jump = 00.0f;
        }

        Vector3 movement = new Vector3(moveHorizontal, jump, moveVertical);
        
        rb.AddForce(movement * speed);
	}
}
