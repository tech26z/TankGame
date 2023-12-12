using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    public GameObject Sun;
	// Use this for initialization
	void Start () {
		//test;
	}
	
	// Update is called once per frame
	void Update () {
        transform.LookAt(Sun.transform);
    }
}
