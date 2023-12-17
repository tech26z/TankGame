using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour {


    //collision between "this" and other (here is collision)
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collision with: " + collision.collider);

        //change color after collisioin
        collision.collider.GetComponent<MeshRenderer>().material.color
            = Color.gray;
    }

    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("contact points: " + collision.contacts.Length);
        for(int i = 0; i < collision.contacts.Length; i++)
        {
            //point is Vector3
            Debug.Log("point " + i + collision.contacts[i].point);
        }

        Vector3 temp = collision.contacts[0].point;
        GameObject temp0 = new GameObject("Point");
        temp0.transform.position = temp;
        Debug.Log("new Point " + temp0.transform.position);
    }

    private void OnCollisionExit(Collision collision)
    {
        collision.collider.GetComponent<MeshRenderer>().material.color
            = Color.cyan;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
