using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject  enemyPrefab;
    public Transform[] spawnPoints;

    public int spawnCount = 10;
   
    private int currentSpan = 0;


    void Start()
    {
        InvokeRepeating("SpawnEnemy", 1f, 2f);
    }

    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        if(currentSpan >= spawnCount)
        {
            CancelInvoke("SpanEnemy");
            return;
        }

        int index = Random.Range(0, spawnPoints.Length);
        Instantiate(enemyPrefab, spawnPoints[index].position,Quaternion.identity);

        currentSpan++;
    }

}

