using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAni : MonoBehaviour
{
    [SerializeField] private GameObject Monster;
    void MonsterAttack() 
    {
        Monster.GetComponent<Animator>().SetTrigger("AttackTrigger");
    }

    void Update()
    {
        if (GlobalData.MonsterState == 0) 
        { 
            MonsterAttack();
            GlobalData.MonsterState = -1;
        }
    }
}
