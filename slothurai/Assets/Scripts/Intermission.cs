using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intermission : MonoBehaviour
{
    
    public float limit = 5f;
    float time;

    // Update is called once per frame
    void Update()
    {
        time+= Time.deltaTime;
        if(time > limit)
            SceneManager.LoadScene("SampleScene 2");
    }
}
