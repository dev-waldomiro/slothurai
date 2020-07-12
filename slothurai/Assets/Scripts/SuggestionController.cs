using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SuggestionController : MonoBehaviour
{
    public Image[] suggestions;
    public Sprite phase;
    public Sprite attack;
    public Sprite crouch;
    public Sprite jump;
    public AudioSource jumpS;
    public AudioSource duckS;
    public AudioSource attackS;
    public AudioSource dodgeS;

    Image theSuggestion;

    void Start()
    {
        theSuggestion = GetComponent<Image>();
    }

    void setPhase ()
    {
        theSuggestion.sprite = phase;
    }

    void setJump ()
    {
        theSuggestion.sprite = jump;
    }

    void setCrouch ()
    {
        theSuggestion.sprite = crouch;
    }

    void setAttack ()
    {
        theSuggestion.sprite = attack;
    }

    public int CreateSuggestion () 
    {
        int randomNumber = Random.Range(1,5);

        switch (randomNumber)
        {
            case 1:
                setJump();
                jumpS.Play();
                break;
            case 2:
                setCrouch();
                duckS.Play();
                break;
            case 3:
                setAttack();
                attackS.Play();
                break;
            case 4:
                setPhase();
                dodgeS.Play();
                break;
        } 
        return randomNumber;  
    }
}
