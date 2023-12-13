using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour {
    float ho, ve;
    public float turnSpeed = 10.0f;
    int count = 0;
    float angle;
	// Use this for initialization
	void Start () {
        Debug.Log("Turned:" + count);
	}
	
	// Update is called once per frame
	void Update () {
        ho = Input.GetAxis("Horizontal");
        
        transform.eulerAngles += new Vector3(0, Time.deltaTime * ho * turnSpeed, 0);
        
        if(ho != 0)
        {
            if(ho > 0)
                angle += transform.rotation.eulerAngles.y;
            else
                angle -= transform.rotation.eulerAngles.y;
            Debug.Log(angle);
        }
        
        
      
        //transform.position += new Vector3(ho, 0, ve) * Time.deltaTime * speed;
    }
}
