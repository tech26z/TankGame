using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyTank : MonoBehaviour {
    
    [Header("Shell Prefab")]
    public GameObject shellPrefab;

    [Header("Move Speed")]
    public float moveSpeed = 1;

    [Header("Turn Speed")]
    public float turnSpeed = 1;

    Transform firePoint;
    float ho, ve;
    bool fire;

    // Use this for initialization
    void Awake()
    {
        firePoint = transform.Find("Barrel/FirePoint");   //find inside "this", myTank objcet
    }
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
        if (fire) //left mouse button
        {
            //generate a shell. parameter:Prefab, position, Quaternion
            GameObject shell = Instantiate(shellPrefab, firePoint.position, Quaternion.identity);
            //shell fly direction is forward direction of "this"
            shell.GetComponent<Shell>().flyDir = transform.forward;
            //Destroy(shell, 3f);
        }

    }
        
}
