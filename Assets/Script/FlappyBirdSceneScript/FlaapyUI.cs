using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FlaapyUI : MonoBehaviour
{
    public static FlaapyUI instance;

    public TextMeshProUGUI score;

    public GameObject GameScoreUI;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }
    private void Update()
    {
        score.text = FlappyBirdManager.Instance.FlappyScore.ToString();
    }

    public void SetUI()
    {
        GameScoreUI.SetActive(true);
    }
}
