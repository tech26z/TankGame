using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {

    public Vector3 flyDir;  //no direction spesified, generic and flexable
    [Header("Fly speed")]
    public float flySpeed = 10f;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += flyDir * Time.deltaTime * flySpeed;
    }
}
