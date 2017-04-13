﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMovement : MonoBehaviour {

    private Rigidbody rb;
    private Vector3 winningForce;
    public ReceieveUDPStream stream;

	// Use this for initialization
	void Awake () {
        rb = GetComponent<Rigidbody>();
        winningForce = new Vector3(0,5000,0);
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.RotateAround(Vector3.zero, Vector3.up, 2.5f * Time.deltaTime);

        if (Input.GetKeyDown("space") || stream.hasTypicalHappened())
        {
            rb.AddForce(winningForce, ForceMode.Force);
        }
        if (transform.position.y < 0) {
            transform.position -= new Vector3(0, transform.position.y, 0);
        }
    }

    void OnMouseDown()
    {
        rb.AddForce(winningForce, ForceMode.Force);
    }


}
