using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{

    public GameObject P1;
    public GameObject P2;
    public GameObject shield;
    private bool isAtP1 = true;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            isAtP1 = !isAtP1;
        }

        if(isAtP1)
        {
            shield.transform.position = P1.transform.position;
        } else if(!isAtP1)
        {
        shield.transform.position = P2.transform.position;
        }
    }
}