using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;


public class Mnu : MonoBehaviour
{
public AudioSource audioS;
public AudioSource bgm;
public AudioClip yooo;
public Parallax pr;

    public void Game()
    {
        StartCoroutine(Go());
    }

     IEnumerator Go(){
        audioS.PlayOneShot(yooo);
        bgm.Stop();
        EventSystem.current.SetSelectedGameObject(null);
        pr.Stop();
        yield return new WaitForSeconds(yooo.length+.5f);

        SceneManager.LoadScene("InterMission");
        yield break;
    }
    public void quitG()
    {
    Application.Quit();
    }
}
