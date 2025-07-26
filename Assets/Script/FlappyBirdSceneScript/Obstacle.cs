using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        FlappyBirdPlayer player = collision.gameObject.GetComponent<FlappyBirdPlayer>();
        if (player != null)
        {
            FlaapyUI.instance.SetUI();
            FlappyBirdManager.Instance.GameOver();
            player.DieAnimation();
        }
    }
}
