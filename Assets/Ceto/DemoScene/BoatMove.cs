using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoatMove : MonoBehaviour {
    public float moveSpeed = 10;
    float ho, ve;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ve = Input.GetAxis("Vertical");

        transform.position += transform.forward * Time.deltaTime * moveSpeed;
     
	}
}
