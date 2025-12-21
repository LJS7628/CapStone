using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class GameManger : MonoBehaviour
{
    GameObject PlayerHP;
    GameObject MonsterHp;
    public GameObject EndButton;
    public GameObject NextButton;
    public GameObject AttackButton;
    public GameObject DefenceButton;

    public Sprite[] sprites;
    public TextMeshProUGUI M_Hp;
    public TextMeshProUGUI P_Hp;
    public TextMeshProUGUI EndText;


    private int PlayerMaxHp;
    private int MonsterMaxHp;


    void Start()
    {
        PlayerMaxHp = GlobalData.PlayerHP[GlobalData.selected];
        MonsterMaxHp = GlobalData.MonsterHP;
        

        PlayerHP = GameObject.Find("Player_Bar");
        MonsterHp = GameObject.Find("Monster_Bar");

        P_Hp.gameObject.SetActive(true);
        M_Hp.gameObject.SetActive(true);
    }


    void Update()
    {
        if (GlobalData.MonsterHP <= (int)Math.Round(MonsterMaxHp * 0.8) && GlobalData.MonsterHP > (int)Math.Round(MonsterMaxHp * 0.6))
        {
            MonsterHp.GetComponent<UnityEngine.UI.Image>().sprite = sprites[0];
        }
        else if (GlobalData.MonsterHP <= (int)Math.Round(MonsterMaxHp * 0.6) && GlobalData.MonsterHP > (int)Math.Round(MonsterMaxHp * 0.4)) 
        {
            MonsterHp.GetComponent<UnityEngine.UI.Image>().sprite = sprites[1];
        }
        else if (GlobalData.MonsterHP <= (int)Math.Round(MonsterMaxHp * 0.4) && GlobalData.MonsterHP > (int)Math.Round(MonsterMaxHp * 0.2))
        {
            MonsterHp.GetComponent<UnityEngine.UI.Image>().sprite = sprites[2];
        }
        else if (GlobalData.MonsterHP <= (int)Math.Round(MonsterMaxHp * 0.2) && GlobalData.MonsterHP >0)
        {
            MonsterHp.GetComponent<UnityEngine.UI.Image>().sprite = sprites[3];
        }
        else if (GlobalData.MonsterHP <= 0)
        {
            GlobalData.MonsterHP = 0;
            GlobalData.M_Dead = 1;
            MonsterHp.GetComponent<UnityEngine.UI.Image>().sprite = sprites[4];
            GlobalData.MonsterHP = MonsterMaxHp;
            

            NextButton.SetActive(true);
            AttackButton.SetActive(false);
            DefenceButton.SetActive(false);
            P_Hp.gameObject.SetActive(false);
            M_Hp.gameObject.SetActive(false);
        }

        M_Hp.text =GlobalData.MonsterHP.ToString() + " / 40";

        //====================================================================================

        if (GlobalData.PlayerHP[GlobalData.selected] <= (int)Math.Round(PlayerMaxHp * 0.8) && GlobalData.PlayerHP[GlobalData.selected] > (int)Math.Round(PlayerMaxHp * 0.6))
        {
            PlayerHP.GetComponent<UnityEngine.UI.Image>().sprite = sprites[0];
        }
        else if (GlobalData.PlayerHP[GlobalData.selected] <= (int)Math.Round(PlayerMaxHp * 0.6) && GlobalData.PlayerHP[GlobalData.selected] > (int)Math.Round(PlayerMaxHp * 0.4))
        {
            PlayerHP.GetComponent<UnityEngine.UI.Image>().sprite = sprites[1];
        }
        else if (GlobalData.PlayerHP[GlobalData.selected] <= (int)Math.Round(PlayerMaxHp * 0.4) && GlobalData.PlayerHP[GlobalData.selected] > (int)Math.Round(PlayerMaxHp * 0.2))
        {
            PlayerHP.GetComponent<UnityEngine.UI.Image>().sprite = sprites[2];
        }
        else if (GlobalData.PlayerHP[GlobalData.selected] <= (int)Math.Round(PlayerMaxHp * 0.2) && GlobalData.PlayerHP[GlobalData.selected] > 0)
        {
            PlayerHP.GetComponent<UnityEngine.UI.Image>().sprite = sprites[3];
        }
        else if (GlobalData.PlayerHP[GlobalData.selected] <= 0)
        {
            GlobalData.PlayerHP[GlobalData.selected] = PlayerMaxHp;
            PlayerHP.GetComponent<UnityEngine.UI.Image>().sprite = sprites[4];
            GlobalData.MonsterHP = MonsterMaxHp;
            GlobalData.isDead = 1;

            EndButton.SetActive(true);
            AttackButton.SetActive(false);
            DefenceButton.SetActive(false);
            P_Hp.gameObject.SetActive(false);
            M_Hp.gameObject.SetActive(false);
        }

        P_Hp.text = GlobalData.PlayerHP[GlobalData.selected].ToString() + " / " + PlayerMaxHp.ToString();


    }

    
}
