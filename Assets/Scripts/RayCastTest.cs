using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastTest : MonoBehaviour {

    Ray ray;
    RaycastHit hit;
    
	void Start () {
        ray = new Ray(Vector3.up, Vector3.right);
	}
	
	// Update is called once per frame
	void Update () {
        if (Physics.Raycast(ray, out hit))
        {
            //Physics.RaycastAll();检测多个
            Debug.Log(hit.collider);
            hit.collider.GetComponent<MeshRenderer>().material.color = Color.green;
            Debug.DrawRay(ray.origin, ray.direction * 5, Color.red);

            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(mouseRay, out hit))
            {
                Debug.DrawLine(Camera.main.transform.position, hit.point, Color.blue);
            }
        };
	}
}
