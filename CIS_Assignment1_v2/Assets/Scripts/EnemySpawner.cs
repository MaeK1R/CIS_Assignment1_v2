/*
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
    public class EnemySpawner : MonoBehaviour
    {
        public Enemy test;
        public GameObject enemy;
        public Transform[] spawnLocations;
        private float spawnDelay;
        public float spawnWait = .5f;


        void Start()
        {
            spawnDelay = spawnWait;
            InvokeRepeating("Spawn", spawnDelay, spawnDelay);

        }
        void Update()
        {

        }
        void Spawn()
        {
            int randPos = Random.Range(0, spawnLocations.Length);
            Instantiate(enemy, spawnLocations[randPos].position, Quaternion.identity);
        }


    }


}