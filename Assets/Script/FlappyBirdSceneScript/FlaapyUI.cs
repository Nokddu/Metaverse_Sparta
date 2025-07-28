using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FlaapyUI : MonoBehaviour
{
    public static FlaapyUI instance;

    public TextMeshProUGUI score;
    public TextMeshProUGUI CurrentScore;
    public TextMeshProUGUI BestScore;

    public GameObject GameScoreUI;
    public GameObject GameStartUI;
    public Button GameStartBtn;
    public Button RestartBtn;
    public Button ExitBtn;

    private void Awake()
    {
        if(instance == null)
            instance = this;
    }

    private void Start()
    {
        Button Gmbtn = GameStartBtn.GetComponent<Button>();
        Button rebtn = RestartBtn.GetComponent<Button>();
        Button exbtn = ExitBtn.GetComponent<Button>();
        Gmbtn.onClick.AddListener(GameSet);
        rebtn.onClick.AddListener(ReStart);
        exbtn.onClick.AddListener(Exit);
    }

    private void Update()
    {
        score.text = FlappyBirdManager.Instance.FlappyScore.ToString();
    }

    public void SetUI()
    {
        CurrentScore.text = FlappyBirdManager.Instance.FlappyScore.ToString();
        if(!PlayerPrefs.HasKey("FlappyBird") || PlayerPrefs.GetInt("FlappyBird") < FlappyBirdManager.Instance.FlappyScore)
        {
            BestScore.text = FlappyBirdManager.Instance.FlappyScore.ToString();
        }
        else
            BestScore.text = PlayerPrefs.GetInt("FlappyBird").ToString();

        GameScoreUI.SetActive(true);
    }

    private void GameSet()
    {
        FlappyBirdManager.Instance.GameStart();
        GameStartUI.SetActive(false);
    }

    private void ReStart()
    {
        SceneManager.LoadScene("FlappyBird");
    }

    private void Exit()
    {
        Time.timeScale = 1;
        SoundManager.instance.ChangeBgm(0);
        SceneManager.LoadScene("MainScene");
    }


}
