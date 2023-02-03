using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementP2 : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private Rigidbody2D rb;

    [Header("Stats")]
    [SerializeField] private float speed = 10;

    public bool p2ded;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {

        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(horizontalInput * -speed, verticalInput * -speed);
        print(p2ded);
    }

    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "enemy")
        {
            p2ded = true;
        }
    }
}
