using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;

public class MouseEvent : MonoBehaviour
{
    public void ClickButton1()
    {
        if (Input.GetMouseButtonDown(0)) 
        {
            GlobalData.choice = 0; 
        }
    }

    public void ClickButton2()
    {
        GlobalData.choice = 1;
    }
    public void ClickButton3()
    {
        GlobalData.choice = 2;
    }
}
