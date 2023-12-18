using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Catcher : MonoBehaviour {

    
    int score = 0;
    float ho;


    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<MeshRenderer>().material.color = Color.green;
        if(other.tag == "Coin")
        {
            Destroy(other.gameObject);
            score++;
            Debug.Log(score);
        }
    }
    // Update is called once per frame
    void Update () {
        

        
            ho = Input.GetAxis("Horizontal");
            //transform.position += transform.right * Time.deltaTime * ho;
            transform.position += Vector3.right * ho * Time.deltaTime * 2;
       
        


	}
}
