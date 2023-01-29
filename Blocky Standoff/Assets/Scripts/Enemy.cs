using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D c)
    {
        if(c.gameObject.tag == "Player")
        {
            Debug.Log("Loosing time");
        }else if(c.gameObject.tag == "Shield")
        {
            Destroy(gameObject);
        }
    }
}
