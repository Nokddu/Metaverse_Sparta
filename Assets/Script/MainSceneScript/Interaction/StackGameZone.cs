using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StackGameZone : MonoBehaviour
{
    string Description = "\n���� �ױ� �����Դϴ�!\n\n����Ű : Space\n\n���Ӽ��� :\n\n�ִ��� ���� ������ ��������!!\n\n���ÿ� ���� �ʰ� �״´ٸ� �й��ϰ� �˴ϴ�!!";
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
