using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    float Speed = 2f;

    float MinY = 0.5f;
    float MaxY = -0.5f;


    private void Start()
    {
        float RandomHeight = Random.Range(MinY, MaxY);
        float currentPosition = transform.position.x;
        transform.position = new Vector2 (currentPosition, RandomHeight);
    }


    private void FixedUpdate()
    {
        transform.position += Vector3.left * Speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            FlappyBirdManager.Instance.AddScore();
        }
        else
        {
            transform.position = new Vector2(4, Random.Range(MinY, MaxY));
            Debug.Log("BackGound");
        }
    }

}
