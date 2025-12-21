using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class LoadGame : MonoBehaviour
{

    public void ChangeScene()
    {
        SceneManager.LoadScene("MiddleScene");
    }

    public void ChaneMenuScene() 
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void ChangeBettleScene() 
    {
        SceneManager.LoadScene("BattleScene");      
    }
}
