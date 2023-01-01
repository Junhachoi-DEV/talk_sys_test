using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class talk_manager : MonoBehaviour
{
    public GameObject t_panel;

    public Image g1;
    public Image g2;
    public Image talk_bar;

    public Text dialog_talk;

    public int id;
    public bool is_talking;


    dialog_controller dialog_con;
    void Awake()
    {
        t_panel.SetActive(false);
        dialog_con = GetComponent<dialog_controller>();
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
                dialog_con.dialog_speed = 0.01f;
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
