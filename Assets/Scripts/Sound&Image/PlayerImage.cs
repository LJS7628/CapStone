using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerImage : MonoBehaviour
{
    public GameObject Player;
    public Sprite[] sprites;
    private int index =GlobalData.index[GlobalData.choice];
    public Sprite[][] animationSprites;
    void Start()
    {

        Player = new GameObject();
        Player = GameObject.Find("P");


        //Player.GetComponent<UnityEngine.UI.Image>().sprite = sprites[index];
        
    }



}
