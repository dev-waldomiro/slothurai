using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMovements : MonoBehaviour
{
    public bool timeForChange;
    Transform startPos;
    Animator animator;
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
        animator = GetComponent<Animator>();
    }

    public IEnumerator Jump ()
    {
        // yield return null;
        if(isGrounded())
        {
            transform.DOJump(startPos.position, jumpPower, 1, timeForJump, false);
            animator.SetBool("isJumping", true);
            yield return new WaitForSeconds(timeForJump);
            animator.SetBool("isJumping", false);
            timeForChange = true;
        }
        animator.SetBool("isJumping", false);
    }

    public IEnumerator Attack ()
    {
        // yield return null;
        attackSpace.enabled = true;
        timeForChange = true;
        animator.SetBool("isAttacking", true);
        yield return new WaitForSeconds(timeForAttack);
        attackSpace.enabled = false;
        animator.SetBool("isAttacking", false);
    }

    public IEnumerator Intangible ()
    {
        // yield return null;
        bcPlayer.enabled = false;
        timeForChange = true;
        animator.SetBool("isIntagible", true);
        yield return new WaitForSeconds(timeForIntangibility);
        bcPlayer.enabled = true;
        animator.SetBool("isIntagible", false);
        timeForChange = true;
    }

    public IEnumerator Crounch ()
    {
        // yield return null;
        bcPlayer.enabled = false;
        timeForChange = true;
        animator.SetBool("isCrouching", true);
        yield return new WaitForSeconds(timeForIntangibility);
        bcPlayer.enabled = true;
        animator.SetBool("isCrouching", false);
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
