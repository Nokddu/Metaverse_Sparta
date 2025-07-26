using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StackGameZone : MonoBehaviour
{
    string Description = "\n스택 쌓기 게임입니다!\n\n조각키 : Space\n\n게임설명 :\n\n최대한 많은 스텍을 쌓으세요!!\n\n스택에 맞지 않게 쌓는다면 패배하게 됩니다!!";
    string Scene = "StackGame";

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
