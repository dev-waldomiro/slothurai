using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void Update()
    {
        StartCoroutine(Killthisbitch());
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Player") Destroy(this.gameObject);
    }

    IEnumerator Killthisbitch()
    {
        yield return new WaitForSeconds(6f);
        Destroy(this.gameObject);
    }
}
