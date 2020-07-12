using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;

    public void Spawn ()
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
    }
}
