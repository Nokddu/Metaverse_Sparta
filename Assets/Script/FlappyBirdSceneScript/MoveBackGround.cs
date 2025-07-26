using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBackGround : MonoBehaviour
{
    [SerializeField] private float Speed = -2;
    void Update()
    {
        transform.position += new Vector3(Speed, 0, 0) * Time.deltaTime;
        if(transform.position.x <= -7.1f)
        {
            transform.position = Vector3.zero;
            Debug.Log("a");

        }
    }
}
