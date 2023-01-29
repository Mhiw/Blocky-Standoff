using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundRotator : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private float rotateSpeed = 0.001f;

    void Update()
    {
        transform.Rotate(0, 0, rotateSpeed);
    }
}
