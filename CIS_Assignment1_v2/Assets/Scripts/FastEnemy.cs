﻿/*
* (Matt Kirchoff)
* (File Name)
* (Assignment1)
* (Describe, in general, the code contained.)
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace CIS452_Assignment1_v2
{
    public class FastEnemy : Enemy
    {
        public void Awake()
        {
            enemyBehavior = new MoveFast();
        }
        public void Update()
        {
            enemyBehavior.Move();
        }
        public override void Die()
        {
            Destroy(gameObject);
        }
    }
}