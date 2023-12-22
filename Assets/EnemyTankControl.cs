using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTankControl : MonoBehaviour {

    public float fireInterval = 3f;
    public float moveSpeed = 3f;
    public float turnSpeed = 1f;
    public GameObject shellPrefab;
    public float shellFlySpeed = 30f;

    Transform tank;
    float distance;
    RaycastHit hit;
    Transform firePoint;
    float timer;

    

    private void Awake()
    {
        tank = GameObject.FindWithTag("MyTank").transform;
        firePoint = transform.Find("Barrel/FirePoint");
    }

    // Update is called once per frame
    void Update () {

        timer += Time.deltaTime;

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

    //return true if no buddy at front distance
    bool checkFrontBuddy(float distance)
    {
        if(Physics.Raycast(firePoint.position,transform.forward, out hit, distance))
        {
            if (hit.collider.transform.root.tag == "EnemyTank")
                return true;
        }
        return false;
    }

    void Fire()
    {
        TurnToTank();
        if (checkFrontBuddy(10))
        {
            return;
        }

        if(timer > fireInterval)
        {
            GameObject shell = Instantiate(shellPrefab, firePoint.position, Quaternion.identity);
            Destroy(shell, 3f);
            //Shell is script, script has both flydir and flySpeed
            //shell fly direction is forward direction of "this"
            shell.GetComponent<Shell>().flyDir = transform.forward * shellFlySpeed;
            timer = 0;

        }
    }

    void Aproach()
    {
        TurnToTank();
        if (!checkFrontBuddy(2))
        {
            transform.position += transform.forward * Time.deltaTime * moveSpeed;
        }
    }

    void Roaming()
    {

    }
}

