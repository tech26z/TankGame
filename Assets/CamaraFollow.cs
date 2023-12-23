using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour {

    public Transform followTarget;

    Vector3 dir;

	// Use this for initialization
	void Start () {
        dir = followTarget.position - transform.position;	
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = Vector3.Lerp(transform.position, followTarget.position - dir, 0.2f);
	}
}
