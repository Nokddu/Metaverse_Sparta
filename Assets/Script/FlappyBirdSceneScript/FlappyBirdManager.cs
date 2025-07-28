using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class FlappyBirdManager : MonoBehaviour
{
    public static FlappyBirdManager Instance;

    private int flappyscore = 0;
    public int FlappyScore { get { return flappyscore; } }

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(gameObject);

        Time.timeScale = 0;
    }

    public void AddScore()
    {
        flappyscore += 1;
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        if(!PlayerPrefs.HasKey("FlappyBird"))
        {
            PlayerPrefs.SetInt("FlappyBird", flappyscore);
        }
        else
        {
            if(PlayerPrefs.GetInt("FlappyBird") >= flappyscore)
            {
                return;
            }
            else
            {
                PlayerPrefs.SetInt("FlappyBird", flappyscore);
            }
        }
    }

    public void GameStart()
    {
        Time.timeScale = 1;
        flappyscore = 0;
    }
}
