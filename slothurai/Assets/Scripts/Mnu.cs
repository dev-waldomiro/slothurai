﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mnu : MonoBehaviour
{
    public void Game()
    {
        SceneManager.LoadScene("SampleScene");
    }

    public void quitG()
    {
        Application.Quit();
    }
}
