using System.Collections;
using System.Collections.Generic;
using UnityEngine;
            /***********************************************************
             created on 2023-12-11 by tech26z.
             it works fine as long as you set the star at global 0,0,0
             ***********************************************************/

public class EarthMove : MonoBehaviour {
    
    [Header("Revolve or not")]
    public bool Revolve;
    [Header("Revolve Speed")]
    public float relvoveSpeed = 3f;
    [Header("Revolve Axis")]
    public Vector3 Axis;
    public Transform Star;            //if using GameObject, then, GameObject.transform.position. for this case, Star.position
    // Use this for initialization
    void Start () {

        Vector3 dir = transform.position - Star.position; //vector from star to planet
        Vector3 normal = Vector3.Cross(Axis, dir);       //normal generated from revolve axis to planet
        
        float angle = Vector3.Angle(dir, Axis);          
        
        if (angle > 90)
        {
            angle = angle - 90;
        }
        else
        {
            angle = 90 - angle;
        }

        //initial set up, once for all
        transform.RotateAround(Star.position, normal, angle);
    }
	
	// Update is called once per frame
	void Update () {
        //self rotate 
        //if (!Revolve)
        //  return;
        transform.Rotate(Vector3.up * 30);
        if(Revolve)
        {
            transform.RotateAround(Star.position, Axis, relvoveSpeed);
        }
    }
}
