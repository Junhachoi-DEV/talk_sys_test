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
        string sample_text = "안녕 나는 나태야. 또 만나는구나...\n 너는 기억이 없을테지만... " +
            "\n 이제 인사하는것도 지겨워!";

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
