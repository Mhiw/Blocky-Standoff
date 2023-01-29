using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroller : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private float moveSpeed = 0.001f;

    void Update()
    {
        transform.position = new Vector2(0, transform.position.y - moveSpeed);
    }
}
