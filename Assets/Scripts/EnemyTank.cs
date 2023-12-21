using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTank : MonoBehaviour {

    public GameObject enemyTankPrefab;
    public float interval = 2f;
    [Range(10,50)]
    public int maxEnemyTank = 20;
    float timer = 0;
    int counter = 0;

	void Start () {
		
	}
	
	
	void Update () {
        timer += Time.deltaTime;

        if(timer > interval)
        {
            if(counter < maxEnemyTank)
            {
                MakeTank();
                counter++;
                timer = 0;
            }
            

            
        }
	}

    void MakeTank()
    {
        float x = 0, z = 0;
        Vector3 position = Vector3.zero;

        do
        {
            x = Random.Range(-20f, 20f);
            z = Random.Range(-20f, 20f);
            position = new Vector3(x, 0.5f, z);

        } while (!positionOK(position));

        int y = Random.Range(0, 360);
       
        Quaternion qua =  Quaternion.Euler(new Vector3(0, y, 0));

        Instantiate(enemyTankPrefab, position, qua);

    }

    bool positionOK(Vector3 position)
    {
        //~represents not check layer 8, because Plane is set at 
        //layer 8 at the layer panel. ! represents no objects in 
        //the sphere, otherwise, has objects
        return !Physics.CheckSphere(position, 2, ~(1 << 8)); 
        
    }
}
