using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{

    public bool killTheGuy = false;

    public bool enemyDefeated = false;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.tag == "Enemy") 
        {
            enemyDefeated = true;
            if(killTheGuy) Destroy(other.gameObject);
        }
    }
}
