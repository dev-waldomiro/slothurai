using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{

    public bool killTheGuy = false;

    public bool enemyDefeated = false;
    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Enemy") 
        {
            enemyDefeated = true;
            if(killTheGuy) Destroy(other.gameObject);
        }
    }
}
