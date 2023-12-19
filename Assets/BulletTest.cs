using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTest : MonoBehaviour {

    public GameObject bulletPrefab;
    public float flySpeed = 30f;
    Ray ray;
    RaycastHit hit;
    float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if(Physics.Raycast(ray, out hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                GameObject shell = Instantiate(bulletPrefab, 
                    Camera.main.transform.position, 
                    Quaternion.identity);

                shell.GetComponent<Rigidbody>().velocity =
                    (hit.point - Camera.main.transform.position)
                    .normalized * flySpeed;
                Destroy(shell, 3);
            }
        }
	}
}
