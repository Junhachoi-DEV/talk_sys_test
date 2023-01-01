using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] //�������� Ŭ�󽺿� �����Ҽ��ֵ��� ���ش�.
public class _dialogue
{
    [TextArea]//�ν�����â�� ���� �̻� �����ְ� �������
    public string dialogue;  //��
    public Image cgs; // ��ü�̹���.(ǥ����ȭ ���)

}
public class dialogue_controller : MonoBehaviour
{
    public Image character_img; 
    public Text dialog_talk;
    public float dialog_speed;

    public int count = 0; //���° �������

    public _dialogue[] dialogues; //����Ʈ

    private void Start()
    {
        character_img.color = new Color(0.3f, 0.3f, 0.3f, 1);
    }

    public void next_dialogue()
    {
        
        dialog_talk.text = "";
        string sample_text = dialogues[count].dialogue;
        
        character_img = dialogues[count].cgs;
        character_img.color = new Color(1, 1, 1, 1); //�����

        //�ε��� ���� ����
        if (count != 0)
        {
            dialogues[count - 1].cgs.color = new Color(0.3f, 0.3f, 0.3f, 1); //��ξ���
        }

        count++;//����
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
