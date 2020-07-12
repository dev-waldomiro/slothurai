using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class DeathMenu : MonoBehaviour
{
    public bool death = false;
    
    public HealthController HC;

    public GameObject DeathPanel;

    public GameObject ResetB;

    public GameObject Pause;

    void Start()
    {
        death = false;
        Time.timeScale = 1f;
    }

    void Update()
    {
        if(HC.health == 0)
        {
            death = true;
            Time.timeScale = 0f;
           DeathPanel.SetActive(true);
           EventSystem.current.SetSelectedGameObject(ResetB);
           HC.health = -1;
        }
    }
    public void Reset() 
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    public void Menu()
        {
            Time.timeScale = 1f;
            SceneManager.LoadScene("MenuScene");
        }
    public void QuitG()
        {
            Application.Quit();
        }
}
