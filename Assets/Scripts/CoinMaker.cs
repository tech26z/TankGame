using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMaker : MonoBehaviour {

    public GameObject coinPrefab;
    public float interval = 2f;
    float timer;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > interval)
        {
            GameObject coin = Instantiate(coinPrefab,
            new Vector3(Random.Range(-3, 3), 6, 0), Quaternion.identity);
            Destroy(coin, 2);
            timer = 0;
        }
    }
}
