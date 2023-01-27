using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private GameObject OtherPlayer;
    [SerializeField] private Rigidbody2D rb;

    [Header("Stats")]
    [SerializeField] private float speed = 10;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        OtherPlayer.transform.position = new Vector2(-transform.position.x, -transform.position.y);

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizontalInput * speed, verticalInput * speed);
    }
}
