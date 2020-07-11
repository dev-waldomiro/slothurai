using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public PlayerMovements playerMovement;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)) 
        {
            playerMovement.Jump();
        }

        if(Input.GetKeyDown(KeyCode.J)) 
        {
            //CALL J FUNCTION
        }
        
        if(Input.GetKeyDown(KeyCode.K)) 
        {
            StartCoroutine(playerMovement.Attack());
        }

        if(Input.GetKeyDown(KeyCode.L)) 
        {
            StartCoroutine(playerMovement.Intangible());
        }
    }

}
