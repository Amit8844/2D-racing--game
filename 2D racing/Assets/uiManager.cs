﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    public Button[] buttons;
    
    public Text scoreText;
    bool gameOver;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
        score = 0;
        InvokeRepeating("scoreUpdate",1.0f,0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + score;
    }
       void scoreUpdate()
       {
           if(!gameOver)
           {
           score +=1;
           }
       }
       public void gameoverActivated()
       {
           gameOver = true;
           foreach(Button button in buttons)
           {
               button.gameObject.SetActive(true);
           }
       }

        public void Play()
        {
         Application.LoadLevel("level1");
        }
    
        public void Pause()
        {
         if(Time.timeScale == 1)
         {
             Time.timeScale = 0;
         }
         else if ( Time.timeScale == 0)
         {
             Time.timeScale = 1;
         }
        }

       
            public void Menu()
            {
                Application.LoadLevel("menu");
            }
            public void Exit()
            {
                Application.Quit();
            }
        
}

