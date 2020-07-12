using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public TrafficLightController traffic;
    public InputController input;
    public EnemyMovement enemy;
    public EnemySpawner spawner;
    public PlayerMovements playerM;
    public PlayerController playerC;
    public HealthController health;

    bool twoLights = false;
    float timeBtwSpawn;
    public float startSpawnTime = 5f;
    public float decreaseTime = 0.4f;
    public float enemySpeed = 0.3f;
    public int playerHealth = 3;

    void Update()
    {

        if(playerM.timeForChange) //add hit by enemy
        {
            input.Trafficlight(twoLights);
            traffic.changeIDog(!input.jumpOn);
            traffic.changeJDog(!input.crouchOn);
            traffic.changeKDog(!input.attackOn);
            traffic.changeLDog(!input.intangibleOn); 
            playerM.timeForChange = false;
        }

        if(timeBtwSpawn <= 0)
        {
            spawner.Spawn();
            timeBtwSpawn = startSpawnTime;
            startSpawnTime -= decreaseTime;
            //enemy.speed += enemySpeed;
        } else 
        {
            timeBtwSpawn -= Time.deltaTime;
        }
        
        if(startSpawnTime <= 3) twoLights = true;

        if(playerC.hasBeenHit)
        {
            health.TakeDamage();
            playerC.hasBeenHit = false;
        }

    }
}
