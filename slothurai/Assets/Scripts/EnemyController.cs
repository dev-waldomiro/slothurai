﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    void Update()
    {
        StartCoroutine(Killthisbitch());
    }

    IEnumerator Killthisbitch()
    {
        yield return new WaitForSeconds(6f);
        Destroy(this.gameObject);
    }
}
