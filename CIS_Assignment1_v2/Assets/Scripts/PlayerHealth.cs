using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("enemy"))
        {
            SceneManager.LoadScene(sceneName: "EndMenu");
            Debug.Log("You lose");
        }
    }
}
