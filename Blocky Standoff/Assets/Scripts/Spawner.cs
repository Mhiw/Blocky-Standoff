using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
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
        }
    }

    private void RestartTime()
    {
        currentTime = startTime;
    }
}
