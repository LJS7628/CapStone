using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SlotMachine : MonoBehaviour
{
    public Sprite[] sprites;
    public float StopTime;
    public GameObject[] slotImage;
    private float totalTime;

    public int[] spritesIndex = new int[3];

    void Start()
    {
        slotImage = new GameObject[3];
        slotImage[0] = GameObject.Find("Player1");
        slotImage[1] = GameObject.Find("Player2");
        slotImage[2] = GameObject.Find("Player3");
        

    }
    void Update()
    {
        totalTime += Time.deltaTime;
        if(totalTime > 0.2f) 
        {
            RandomingImage();
            totalTime = 0.0f;
        }
        
    }

    void RandomingImage()
    {
        for (int i = 0; i < slotImage.Length; i++) 
        {
            GlobalData.index[i] = Random.Range(i * 2, i * 2 + 2);
            slotImage[i].GetComponent<UnityEngine.UI.Image>().sprite = sprites[GlobalData.index[i]];
        }
    }



    void EndRand()
    {
        enabled = false;
    }

    public void StopRand()
    {
        Invoke("EndRand", StopTime);

    }
    public void StartRand()
    {
        enabled = true;
    }
}
