using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputController : MonoBehaviour
{

    public PlayerMovements playerMovement;
    
    [HideInInspector] public bool jumpOn = true;
    [HideInInspector] public bool crouchOn = true;
    [HideInInspector] public bool attackOn = true;
    [HideInInspector] public bool intangibleOn = true;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.I)) 
        {
            if(jumpOn)
                playerMovement.Jump();
            else {playerMovement.Dizzy();}
        }

        if(Input.GetKeyDown(KeyCode.J)) 
        {
            if(crouchOn) {playerMovement.Dizzy();}
        }
        
        if(Input.GetKeyDown(KeyCode.K)) 
        {
            if(attackOn)
                StartCoroutine(playerMovement.Attack());
            else {playerMovement.Dizzy();}
        }

        if(Input.GetKeyDown(KeyCode.L)) 
        {
            if(intangibleOn)
                StartCoroutine(playerMovement.Intangible());
            else {playerMovement.Dizzy();}
        }
    }

    public void Trafficlight (bool twoLights) 
    {

        jumpOn = true;
        crouchOn = true;
        attackOn = true;
        intangibleOn = true;

        int randomNumber = Random.Range(1,5);

        switch (randomNumber)
        {
            case 1:
                jumpOn = false;
                break;
            case 2:
                crouchOn = false;
                break;
            case 3:
                attackOn = false;
                break;
            case 4:
                intangibleOn = false;
                break;
        }

        if(twoLights) {
            randomNumber = Random.Range(1,5);

            switch (randomNumber)
            {
                case 1:
                    jumpOn = false;
                    break;
                case 2:
                    crouchOn = false;
                    break;
                case 3:
                    attackOn = false;
                    break;
                case 4:
                    intangibleOn = false;
                    break;
            }
        }
    }

}
