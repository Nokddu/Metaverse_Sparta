using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdZone : MonoBehaviour
{
    string Description = "간단한 플레피 버드 게임입니다\n\n조각키 : Space\n\n게임설명 :\n\n최대한 오래 살아남으세요!!\n\n장애물에 부딪히면 게임이 종료됩니다!!";
    string Scene = "FlappyBird"; 

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            UIManager.Instance.DescriptionText(Description, Scene);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !UIManager.Instance.isLoading)
        {
            UIManager.Instance.HideUI();
        }
    }
}
