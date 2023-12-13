using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTank : MonoBehaviour {
    public float ho, ve;
    [Header("Shell Prefab")]
    public GameObject shellPrefab;

    [Header("Move Speed")]
    public float moveSpeed = 1;

    [Header("Turn Speed")]
    public float turnSpeed = 1;

    bool fire;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ho = Input.GetAxis("Horizontal");
        ve = Input.GetAxis("Vertical");
        fire = Input.GetButtonDown("Fire1");

        transform.position += transform.forward * Time.deltaTime * ve;
        transform.eulerAngles += new Vector3(0, ho * turnSpeed, 0);
        //transform.Rotate(0, 1 * ho, 0);
        if (fire)
        {
            Instantiate(shellPrefab, firePoint.transform.position, identity); //Prefab, position, Quaternion
        }
	}
}
