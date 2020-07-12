using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMovements : MonoBehaviour
{
    public bool timeForChange;
    Transform startPos;
    BoxCollider2D bcPlayer;
    BoxCollider2D attackSpace;
    [SerializeField] float timeForJump = 3.3f;
    [SerializeField] float jumpPower = 4f;
    [SerializeField] float timeForIntangibility = 8f;
    [SerializeField] float timeForAttack = 4f;

    [SerializeField] LayerMask plataform;

    void Start()
    {
        timeForChange = false;
        startPos = this.transform;
        bcPlayer = GetComponent<BoxCollider2D>();
        attackSpace = this.transform.Find("AttackBox").GetComponent<BoxCollider2D>();
    }

    public void Jump ()
    {
        if(isGrounded())
        {
            transform.DOJump(startPos.position, jumpPower, 1, timeForJump, false);
            timeForChange = true;
        }
    }

    public IEnumerator Attack ()
    {
        yield return null;
        attackSpace.enabled = true;
        timeForChange = true;
        Debug.Log("He attac now");
        yield return new WaitForSeconds(timeForAttack);
        attackSpace.enabled = false;
        Debug.Log("But now he aint");
    }

    public IEnumerator Intangible ()
    {
        yield return null;
        bcPlayer.enabled = false;
        timeForChange = true;
        Debug.Log("Is Intangible");
        yield return new WaitForSeconds(timeForIntangibility);
        bcPlayer.enabled = true;
        Debug.Log("Now he's not.");
        timeForChange = true;
    }

    public void Dizzy ()
    {
        Debug.Log("Aint working biatch.");
        timeForChange = true;
    }

    private bool isGrounded()
    {
        float extraHeigth = 0.01f;
        RaycastHit2D raycastHit = Physics2D.Raycast(bcPlayer.bounds.center, Vector2.down, bcPlayer.bounds.extents.y + extraHeigth, plataform);
        return (raycastHit.collider != null);
    }
}
