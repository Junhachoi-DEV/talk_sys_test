using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable] //직접만든 클라스에 접근할수있도록 해준다.
public class _dialogue
{
    [TextArea]//인스펙터창에 한줄 이상 쓸수있게 만들어줌
    public string dialogue;  //글
    public Image cgs; // 교체이미지.(표정변화 등등)
    
}
public class dialogue_controller : MonoBehaviour
{
    public Image character_img; 
    public Text dialog_talk;
    public float dialog_speed;

    public int count = 0; //몇번째 대사인지

    public _dialogue[] dialogues; //리스트

    
    public void next_dialogue()
    {
        dialog_talk.text = "";
        string sample_text = dialogues[count].dialogue;
        character_img = dialogues[count].cgs;
        count++;
        StartCoroutine(typing(sample_text));
    }

    IEnumerator typing(string text)
    {
        foreach (char letter in text.ToCharArray())//문자열을 한 글자씩 쪼개서 이를 char타입의 배열에 집어넣어줌
        {
            dialog_talk.text += letter;
            yield return new WaitForSeconds(dialog_speed);
        }
    }
}
