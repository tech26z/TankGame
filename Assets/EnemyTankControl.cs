using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankControl : MonoBehaviour {

    public float fireInterval = 3f;
    public float moveSpeed = 3f;
    public float turnSpeed = 1f;
    Transform tank;
    float distance;
    

    private void Awake()
    {
        tank = GameObject.FindWithTag("MyTank").transform;
    }

    // Update is called once per frame
    void Update () {
       distance = Vector3.Distance(transform.position, tank.position);
        if (distance < 10)
        {
            TurnToTank();
            Fire();
            //fire
        }
        else if (distance < 20)
        {
            //aproach
            Aproach();
        }
        else
        {
            //roaming
        }
	}

    void TurnToTank()
    {
        Vector3 dir = tank.position - transform.position;
        TurnTo(dir);
    }
    void TurnTo(Vector3 dir)
    {
        //aim at
        Quaternion targetQua =
            Quaternion.LookRotation(dir);
        transform.rotation = Quaternion.Lerp(transform.rotation, targetQua, Time.deltaTime * turnSpeed);
    }

    void Fire()
    {

    }

    void Aproach()
    {
        TurnToTank();
    }

    void Roaming()
    {

    }
}
