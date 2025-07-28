using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlappyBirdPlayer : MonoBehaviour
{
    Rigidbody2D _rigidbody;
    Animator animator;
    FlaapyUI flappyUI;

    [SerializeField] int Power = 3;

    private float maxAngle = 25f;
    private float minAngle = -45f;
    private float rotationSpeed = 5f;
    private void Start()
    {
        flappyUI = GetComponent<FlaapyUI>();
        _rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.velocity = Vector2.up * Power;
        }

        Rotate();
    }

    private void Rotate()
    {
        float targetAngle = Mathf.Lerp(minAngle, maxAngle, (_rigidbody.velocity.y + Power) / (Power * 2));
        
        Quaternion targetRotation = Quaternion.Euler(0,0,targetAngle);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime * rotationSpeed);
    }
    public void DieAnimation()
    {
        animator.SetBool("IsDie", true);
    }
}
