using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour {

    Rigidbody rig;

    private void Awake()
    {
        rig = this.GetComponent<Rigidbody>();
    }
    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(rig.velocity);
        transform.position += Vector3.forward * Time.deltaTime * 3;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rig.velocity = Vector3.up * 5; //vilocity is force, not transform.position
        }
        
    }
        
        
      
        
    
}
