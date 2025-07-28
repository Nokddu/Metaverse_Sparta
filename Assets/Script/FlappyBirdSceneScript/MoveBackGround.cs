using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    [SerializeField] private float Speed = 2f;
    void Update()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
        if(transform.position.x <= -7.1f)
        {
            transform.position = Vector3.zero;
        }
    }
}
