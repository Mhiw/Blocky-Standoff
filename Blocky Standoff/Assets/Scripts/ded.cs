using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ded : MonoBehaviour
{

    public MovementP2 p2;
    public Movement p;

    void Start()
    {
        gameObject.transform.localPosition = new Vector3(5000,0,0);
    }

    void Update()
    {
        if (p2.p2ded)
        {
            gameObject.transform.localPosition = new Vector3(0,0,0);
            Time.timeScale = 0f;
            gameObject.SetActive(true);
        }

        if (p.pded)
        {
            gameObject.transform.localPosition = new Vector3(0,0,0);
            Time.timeScale = 0f;
            gameObject.SetActive(true);
        }
    }
}
