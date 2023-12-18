using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Trigger start: " + other);
        other.GetComponent<MeshRenderer>().material.color = Color.grey;
        this.GetComponent<MeshRenderer>().material.color = Color.black;
    }

    private void OnTriggerStay(Collider other)
    {
        
    }

    private void OnTriggerExit(Collider other)
    {
        
    }

    // Update is called once per frame
    void Update () {
		
	}
}
