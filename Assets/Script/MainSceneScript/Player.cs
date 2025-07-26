using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    Rigidbody2D _rigid;


    Animator animator;
    void Start()
    {
        _rigid = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    private void FixedUpdate()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        float moveY = Input.GetAxisRaw("Vertical");

        Vector2 move = new Vector2(moveX, moveY).normalized;
        MoveAnimation(move);
        _rigid.velocity = move * speed;

    }

    private void MoveAnimation(Vector2 move)
    {
        if (move.x == 0 || move.y == 0)
        {
            animator.SetBool("Right", false);
            animator.SetBool("Left", false);
            animator.SetBool("Up", false);
            animator.SetBool("Down", false);
        }
        if (move.x > 0)
        {
            animator.SetBool("Right", true);
        }
        else if(move.x < 0)
        {
            animator.SetBool("Left", true);
        }
        else if (move.y > 0)
        {
            animator.SetBool("Up", true);
        }
        else if (move.y < 0)
        {
            animator.SetBool("Down", true);
        }
    }
}
