using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthMove : MonoBehaviour {
    public GameObject Sun;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //transform.RotateAround(new Vector3(0, 0, 0), new Vector3(0, 1, 0), 2.0f);
        //transform.Rotate(0, 0, 1);
        //transform.Rotate(new Vector3(0, 0, 3));
        //transform.eulerAngles += new Vector3(0, 0, 25);
        //transform.position = new Vector3(0, 0, 0.000001f);
        //transform.Translate(new Vector3(0, 0, 0.2f));
        transform.RotateAround(Sun.transform.position, new Vector3(0, 1, 0), 0.5f);
        
    }
}
