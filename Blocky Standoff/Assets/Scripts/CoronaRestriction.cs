using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoronaRestriction : MonoBehaviour
{
    [Header("Refrences")]
    [SerializeField] private GameObject P1;
    [SerializeField] private GameObject P2;

    void Update()
    {
        float distance = Vector3.Distance(P1.transform.position, P2.transform.position)
        if(distance < 0.5f)
        {
            //Banana
        }
    }
}
