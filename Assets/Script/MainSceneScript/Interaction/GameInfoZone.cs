using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInfoZone : MonoBehaviour
{
    [Header("�� ����")]
    [SerializeField]
    private int bgmSelect;

    [SerializeField]
    [TextArea(10,15)]
    private string Description = "���� ���� �Է�";

    [SerializeField]
    private string Scene = "SceneName";


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            UIManager.Instance.DescriptionText(Description, Scene, bgmSelect);
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
