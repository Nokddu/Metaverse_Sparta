using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;

public class UIManager : MonoBehaviour
{
    private static UIManager instance;
    public static UIManager Instance { get { return instance; } }

    public GameObject Manual;
    public TextMeshProUGUI Desciption;
    public Button button;

    private string LoadSceneName;
    
    public bool isLoading { get; private set; }

    private void Awake()
    {
        if (Instance == null)
        {
            instance = this;
        }
        else if (Instance != this)
            Destroy(gameObject);

        Manual.SetActive(false);
    }

    public void DescriptionText(string Text,  string SceneName)
    {
        Desciption.text = Text;
        button.onClick.RemoveAllListeners();
        button.onClick.AddListener(StartBtn);
        isLoading = false;
        LoadSceneName = SceneName;
        Manual.SetActive(true);
    }

    public void HideUI()
    {
        Manual.SetActive(false);
    }

    public void StartBtn()
    {
        isLoading = true;
        if (LoadSceneName != null) SceneManager.LoadScene(LoadSceneName);
        else Debug.Log("LoadSceneName이 Null 입니다");
    }
}
