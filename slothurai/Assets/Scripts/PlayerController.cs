using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool hasBeenHit = false;
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Enemy") 
        {
            hasBeenHit = true;
            Destroy(other.gameObject);
        }
    }
}
