using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMovements : MonoBehaviour
{
    Transform startPos;
    BoxCollider2D bcPlayer;
    BoxCollider2D attackSpace;
    [SerializeField] float timeForJump = 3f;
    [SerializeField] float jumpPower = 4f;
    [SerializeField] float timeForIntangibility = 4f;
    [SerializeField] float timeForAttack = 4f;

    void Start()
    {
        startPos = this.transform;
        bcPlayer = GetComponent<BoxCollider2D>();
        attackSpace = this.transform.Find("AttackBox").GetComponent<BoxCollider2D>();
    }

    public void Jump ()
    {
        transform.DOJump(startPos.position, jumpPower, 1, timeForJump, false);
    }

    public void Duck ()
    {
        //
    }

    public IEnumerator Attack ()
    {
        yield return null;
        attackSpace.enabled = true;
        Debug.Log("He attac now");
        yield return new WaitForSeconds(timeForAttack);
        attackSpace.enabled = false;
        Debug.Log("But now he aint");
    }

    public IEnumerator Intangible ()
    {
        yield return null;
        bcPlayer.enabled = false;
        Debug.Log("Is Intangible");
        yield return new WaitForSeconds(timeForIntangibility);
        bcPlayer.enabled = true;
        Debug.Log("Now he's not.");
    }
}
