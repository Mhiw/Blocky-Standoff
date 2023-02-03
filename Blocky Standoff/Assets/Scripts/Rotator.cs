using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [Header("Stats")]
    [SerializeField] private float rotateSpeed = 5.0f;

    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, rotateSpeed);
        }else if(Input.GetKey(KeyCode.LeftArrow))        
        {
            transform.Rotate(0, 0, -rotateSpeed);
        }
    }
}
