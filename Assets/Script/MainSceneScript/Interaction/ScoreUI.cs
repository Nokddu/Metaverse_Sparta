using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class ScoreUI : MonoBehaviour
{
    public GameObject Direction;
    public GameObject FlappyBirdScoreUI;

    public Button ShowFlappyBirdScore;

    public TextMeshProUGUI FlappyScoreText;

    
    public void FlappyScoreCoroutine()
    {
        StartCoroutine(FlappyScore());
    }

    private IEnumerator FlappyScore()
    {
        FlappyScoreText.text = PlayerPrefs.GetInt("FlappyBird").ToString();
        Direction.SetActive(false);
        FlappyBirdScoreUI.SetActive(true);

        yield return new WaitForSeconds(2f);
        FlappyBirdScoreUI.SetActive(false);
    }    
}
