using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTank : MonoBehaviour {

    public GameObject enemyTankPrefab;
    public float interval = 2f;
    [Range(10,30)]
    public int maxEnemyTank = 20;
    float timer = 0;
    int counter = 0;

	void Start () {
		
	}
	
	
	void Update () {
        timer += Time.deltaTime;

        if(timer > interval)
        {
            if(counter <= maxEnemyTank)
            {
                MakeTank();
                timer = 0;
            }
            

            
        }
	}

    void MakeTank()
    {
        float x = Random.Range(-40f, 40f);
        float z = Random.Range(-40f, 40f);

        Instantiate(enemyTankPrefab, new Vector3(x, 0.5f, z), Quaternion.identity);
    }
}
