using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlappyBirdZone : MonoBehaviour
{
    string Description = "������ �÷��� ���� �����Դϴ�\n\n����Ű : Space\n\n���Ӽ��� :\n\n�ִ��� ���� ��Ƴ�������!!\n\n��ֹ��� �ε����� ������ ����˴ϴ�!!";
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
