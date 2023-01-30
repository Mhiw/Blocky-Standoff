using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D c)
    {
        if(c.gameObject.tag == "Shield")
        {
            Destroy(gameObject);
        }
    }
}
