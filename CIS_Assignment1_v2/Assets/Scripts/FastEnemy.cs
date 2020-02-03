﻿/*
* (Matt Kirchoff)
* (FastEnemy)
* (Assignment2)
* (Class Fast enemy would be instatiated in)
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