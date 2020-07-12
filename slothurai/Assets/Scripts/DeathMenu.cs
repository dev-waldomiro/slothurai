using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DeathMenu : MonoBehaviour
{
    public static bool death = false;
    
    public HealthController HC;

    public GameObject DeathPanel;

    public GameObject ResetB;

    public GameObject Pause;

    void Start()
    {
        Time.timeScale = 1f;
    }

    void Update()
    {
        if(HC.health == 0)
        {
            Time.timeScale = 0f;
           DeathPanel.SetActive(true);
           EventSystem.current.SetSelectedGameObject(ResetB);
        }
    }
    public void Reset() 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            EventSystem.current.SetSelectedGameObject(null);
            
        }
    public void Menu()
        {
            SceneManager.LoadScene("MenuScene");
        }
    public void QuitG()
        {
            Application.Quit();
        }
}
