﻿/*
* (Matt Kirchoff)
* (MainMenu)
* (Assignment2)
* (Interface to switch scenes to play game.)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene(sceneName: "SampleScene");
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        
    }
}
