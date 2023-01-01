using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialog_controller : MonoBehaviour
{
    public Text dialog_talk;
    public float dialog_speed;

    void Start()
    {
        dialog_talk.text = "";
        string sample_text = "�ȳ� ���� ���¾�. �� �����±���...\n �ʴ� ����� ����������... " +
            "\n ���� �λ��ϴ°͵� ���ܿ�!";

        StartCoroutine(typing(sample_text));
    }

    IEnumerator typing(string text)
    {
        foreach (char letter in text.ToCharArray())//���ڿ��� �� ���ھ� �ɰ��� �̸� charŸ���� �迭�� ����־���
        {
            dialog_talk.text += letter;
            yield return new WaitForSeconds(dialog_speed);
        }
    }
}
