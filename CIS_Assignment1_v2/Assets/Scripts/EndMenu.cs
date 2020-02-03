/*
* (Matt Kirchoff)
* (EndMenu)
* (Assignment2)
* (Interface to continue playing game or exit.)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        if (Input.GetKey(KeyCode.R))
        {
            SceneManager.LoadScene(sceneName: "SampleScene");
        }
        if (Input.GetKey(KeyCode.M))
        {
            SceneManager.LoadScene(sceneName: "Menu");
        }

        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
        
    }
}
