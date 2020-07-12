using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public float ref_speed = 5f; //speed reference
    public float speed 
    {
        get { return ref_speed; }
        set { ref_speed = value; }
    }

    void Start()
    {
        
    }


    void Update()
    {
        transform.Translate((-1) * Vector3.right * Time.deltaTime * ref_speed, Camera.main.transform);
    }

}
