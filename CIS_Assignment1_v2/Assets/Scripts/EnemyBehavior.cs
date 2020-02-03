﻿/*
* (Matt Kirchoff)
* (EnemyBehavior)
* (Assignment2)
* (Enemy behavior classes. various enemy speeds and takes from enemy behavior interface)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment1_v2
{
    public class MoveFast : MonoBehaviour, IEnemyBehavior
    {
        public Transform playerPos;
        public float speed = 5;
        public void Move()
        {
            //playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            //transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        }
    }
    public class MoveMid : MonoBehaviour, IEnemyBehavior
    {
        public Transform playerPos;
        public float speed = 3;
        public void Move()
        {
            playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        }
    }
    public class MoveSlow : MonoBehaviour, IEnemyBehavior
    {
        public Transform playerPos;
        public float speed = 1;
        public void Move()
        {
            playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            transform.position = Vector2.MoveTowards(transform.position, playerPos.position, speed * Time.deltaTime);
        }
    }
}