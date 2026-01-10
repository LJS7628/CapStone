using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAni : MonoBehaviour
{
    [SerializeField] private GameObject[] Players;
    [SerializeField] private GameObject[] _Effects;
    private int _currentActivePlayer = 0;

    void InitPlayers()
    {
        foreach (var player in Players)
        {
            player.SetActive(false);
        }

        foreach (var effect in _Effects) 
        { 
             effect.SetActive(false);
        }

    }

    void SetPlayer(int index)
    {
        InitPlayers();
        Players[index].SetActive(true);  
        _currentActivePlayer = index;
    }

    void PlayerAttack()
    {
        Players[_currentActivePlayer].GetComponent<Animator>().SetTrigger("AttackTrigger");
        _Effects[_currentActivePlayer].SetActive(true);
        _Effects[_currentActivePlayer].GetComponent<Animator>().SetTrigger("EffectTrigger");
    }

    void PlayerDead() 
    {
            Players[_currentActivePlayer].GetComponent<Animator>().SetTrigger("IsDead");         
    }

    void PlayerHurt()
    {
        Players[_currentActivePlayer].GetComponent<Animator>().SetTrigger("IsHurt");
    }
    void Start()
    {
        SetPlayer(GlobalData.selected);

    }

    void Update()
    {
        if (GlobalData.isPressed == 1) 
        { 
            PlayerAttack();
            GlobalData.isPressed = 0;
            
        }
        if (GlobalData.isDead == 1) 
        {
            PlayerDead();
            GlobalData.isDead = 0;  
        }
        if (GlobalData.isHurt == 1) 
        {
            PlayerHurt();
            GlobalData.isHurt = 0;
            
        }


    }
}
