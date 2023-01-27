using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private GameObject OtherPlayer;

    void Update()
    {
        OtherPlayer.transform.position = new Vector2(-transform.position.x, -transform.position.y);
    }
}
