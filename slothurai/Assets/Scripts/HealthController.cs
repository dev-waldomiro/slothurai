using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    int hearts = 3;
    public int health;

    public HealthController healthController;

    public Image[] heartsDisplayed;

    void Start()
    {
        health = hearts;
    }

    // Update is called once per frame
    void Update()
    {
        for(int i = 0; i < heartsDisplayed.Length; i++)
        {
            if(i < health)
            {
                heartsDisplayed[i].enabled = true;
            } else {
                heartsDisplayed[i].enabled = false;
            }
        }
    }

    public void TakeDamage ()
    {
        health -= 1;
    }
}
