using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject[] spawnPoints;
    [SerializeField] private GameObject[] players;

    [Header("Stats")]
    [SerializeField] private float startTime = 10f;

    float currentTime = 10;

    private void Update()
    {
        if(currentTime > 0)
        {
            currentTime -= Time.deltaTime * 10f;
        } else
        {
            RestartTime();
            Spawn();
        }
    }

    private void Spawn()
    {
        GameObject enemyObj = Instantiate(enemy, spawnPoints[Random.Range(0, 8)].transform.position, Quaternion.identity);
        Enemy enemyScr = enemyObj.GetComponent<Enemy>();
        enemyScr.target = players[Random.Range(0, 2)].transform;
    }

    private void RestartTime()
    {
        currentTime = startTime;
    }
}
