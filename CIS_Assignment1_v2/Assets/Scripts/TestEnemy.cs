/*
* (Matt Kirchoff)
* (TestEnemy)
* (Assignment2)
* (Enemy code used to test player mechanics in game)
*/


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestEnemy : MonoBehaviour
{
    public Transform playerPos;
    private int speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(1, 6);
    }

    // Update is called once per frame
    void Update()
    {
        playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);


    }
    void OnTrigerEnter2D(Collider2D col)
    {
        Debug.Log("test");

        if (col.CompareTag("enemy"))
        {
            Debug.Log("You lose");
        }

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            Physics2D.IgnoreLayerCollision(8,9);
        }
    }
     

}