using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BattleLogic : MonoBehaviour
{
    private int P_AP;
    private int M_AP;
    private int index = GlobalData.index[GlobalData.choice];


    private void Start()
    {
        GlobalData.selected = index;
        Debug.Log("selected : "+GlobalData.selected);
        for (int i = 0; i < 6; i++) 
        {
            GlobalData.PlayerHP[i] = 30 + i * 5;
            GlobalData.PlayerDefence[i] = 12 - i * 2;
        }
    }

    public void OnAttackButton() 
    {
        P_AP = GlobalData.PlayerAttack + Random.Range(-2, 6);
        GlobalData.MonsterState = Random.Range(0, 2);
        GlobalData.isPressed = 1;
        if (GlobalData.MonsterState == 0)
        {
            GlobalData.MonsterHP -= P_AP;
            M_AP = GlobalData.PlayerAttack + Random.Range(-3, 6);
            if(GlobalData.MonsterHP > 0) { GlobalData.PlayerHP[GlobalData.selected] -= M_AP; }
            GlobalData.isHurt = 1;
        }
        else if (GlobalData.MonsterState == 1) 
        {
            GlobalData.PlayerHP[GlobalData.selected] -= (int)Mathf.RoundToInt(GlobalData.MonsterDefence*0.3f);
        }


    }

    public void OnDefenceButton() 
    {
        GlobalData.MonsterState = Random.Range(0, 2);
        GlobalData.isPressed = 2;
        if (GlobalData.MonsterState == 0) 
        { 
            GlobalData.MonsterHP -= (int)Mathf.RoundToInt(GlobalData.PlayerDefence[GlobalData.selected] * 0.3f);
        }
        else if(GlobalData.MonsterState == 1) 
        {
            GlobalData.PlayerHP[GlobalData.selected] -= 3;
        }
    }


    
}
