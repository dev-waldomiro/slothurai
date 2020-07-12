using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool GameP = false;

    public GameObject Pauseme;

    public DeathMenu DM;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
         if(DM.death == false)
            {
            if (GameP)
            {
                RES();
            }else
            {
                PAL();
            }
            }
         }
    }
    public void RES()
    {
        Pauseme.SetActive(false);
        Time.timeScale = 1f;
        GameP = false;
    }
    public void PAL()
    {
        Pauseme.SetActive(true);
        Time.timeScale = 0f;
        GameP = true;
    }
    public void Menu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("MenuScene");
    }
    public void quitG()
    {
    Application.Quit();
    }
}
