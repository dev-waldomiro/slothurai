using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    float timeBtwSpawn;
    public float startTimeBtwSpawn = 5f;
    float decreaseTime;

    void Update()
    {
        if(timeBtwSpawn <= 0)
        {
            Instantiate(enemy, transform.position, Quaternion.identity);
            timeBtwSpawn = startTimeBtwSpawn;
        } else {
            timeBtwSpawn -= Time.deltaTime;
        }
    }

}
