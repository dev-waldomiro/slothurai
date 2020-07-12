using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float speed = 200f;
    public float startPos, length;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position += new Vector3(-1*speed*Time.deltaTime, 0, 0);
        // Debug.Log(transform.position.x);
        if(transform.position.x < startPos-length)
            this.gameObject.transform.position = new Vector3(startPos, transform.position.y, 0);
    }

    public void Stop(){
        this.speed = 0;
    }
}
