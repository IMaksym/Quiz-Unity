﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey("escape"))  // если нажата клавиша Esc (Escape)
        {
            Application.Quit();    // закрыть приложение
        }
    }


    public GameObject[] Levels;
    public GameObject ResetScreen, End;

    int currentLevel;


    public void wrongAnswer()
    {
        ResetScreen.SetActive(true);
    }

    public void ResetGame()
    {
        Application.LoadLevel(Application.loadedLevel);
    }

    


    public void correctAnswer()
    {
        if (currentLevel + 1 != Levels.Length)
        {
            Levels[currentLevel].SetActive(false);

            currentLevel++;
            Levels[currentLevel].SetActive(true);
        }
        else
        {
            End.SetActive(true);
            Levels[currentLevel].SetActive(false);
        }
    }


}