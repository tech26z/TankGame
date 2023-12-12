using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    float ho, ve;
    float speed = 1.0f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ho = Input.GetAxis("Horizontal");
        ve = Input.GetAxis("Vertical");

        transform.position += new Vector3(ho, 0, ve) * Time.deltaTime * speed;
    }
}
