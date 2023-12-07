using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTank : MonoBehaviour {
    public float ho, ve;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ho = Input.GetAxis("Horizontal");
        ve = Input.GetAxis("Vertical");

        transform.position += transform.forward * Time.deltaTime * ve;
        transform.Rotate(0, 1 * ho, 0);
	}
}
