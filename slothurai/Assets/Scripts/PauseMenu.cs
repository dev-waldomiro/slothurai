using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public static bool GameP = false;

    public GameObject Pauseme;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
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
    void RES()
    {
        Pauseme.SetActive(false);
        Time.timeScale = 1f;
        GameP = false;
    }
    void PAL()
    {
        Pauseme.SetActive(true);
        Time.timeScale = 0f;
        GameP = true;
    }
}
