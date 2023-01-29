using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private GameObject enemy;
    [SerializeField] private GameObject[] spawnPoints;

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
        //Instantiate(enemy, spawnPoints[Random.Range(0, spawnPoints.Length - 1)].transform.position, Quaternion.identity);
    }

    private void RestartTime()
    {
        currentTime = startTime;
    }
}
