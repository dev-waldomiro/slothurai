using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrafficLightController : MonoBehaviour
{
    Graphic iDog;
    Graphic jDog;
    Graphic kDog;
    Graphic lDog;

    void Start()
    {
        
        iDog = GetChildWithName(this.gameObject, "IButton").GetComponent<Graphic>();
        jDog = GetChildWithName(this.gameObject, "JButton").GetComponent<Graphic>();
        kDog = GetChildWithName(this.gameObject, "KButton").GetComponent<Graphic>();
        lDog = GetChildWithName(this.gameObject, "LButton").GetComponent<Graphic>();
    }

    GameObject GetChildWithName(GameObject obj, string name)
    {
        Transform trans = obj.transform;
        Transform childTrans = trans.Find(name);
        if (childTrans != null) 
        {
            return childTrans.gameObject;
        } else {
            return null;
        }
    }

    public void changeIDog (bool change)
    {
        if(change)
            iDog.color = Color.black;
        else iDog.color = Color.white;
    }

    public void changeJDog (bool change)
    {
        if(change)
            jDog.color = Color.black;
        else jDog.color = Color.white;
    }

    public void changeKDog (bool change)
    {
        if(change)
            kDog.color = Color.black;
        else kDog.color = Color.white;
    }

    public void changeLDog (bool change)
    {
        if(change)
            lDog.color = Color.black;
        else lDog.color = Color.white;
    }
}
