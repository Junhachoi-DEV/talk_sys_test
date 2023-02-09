using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class talk_manager : MonoBehaviour
{
    public GameObject t_panel;

    //public Image[] charecter;
    //public Image talk_bar;

    //public Text dialog_talk;

    //public int id;
    public bool is_talking;


    dialogue_controller dialogue_con;
    void Awake()
    {
        t_panel.SetActive(false);
        dialogue_con = GetComponent<dialogue_controller>();
    }
    void Update()
    {
        is_talking_start();
    }

    void is_talking_start()
    {
        if (is_talking)
        {
            t_panel.SetActive(true);
            if (Input.GetMouseButtonDown(0))
            {
                if(dialogue_con.count < dialogue_con.dialogues.Length) //´ëÈ­°¡ ³¡³ª±âÀü
                {
                    dialogue_con.next_dialogue();
                }
                else
                {
                    is_talking = false;
                }
                
            }
        }
        else
        {
            t_panel.SetActive(false);
        }
    }

    public void is_t_start_botton()
    {
        is_talking = true;
    }
}
