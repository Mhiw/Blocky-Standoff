using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject P1;
    public GameObject P2;
    public GameObject shield;
    private bool isAtP1 = true;

    private float currentTime = 0.01f;
    private float startTime = 0.01f;
    public float cooldownSpeed;

    void Update()
    {
        ShieldSwitch();
        if(currentTime > 0.0f)
        {
        currentTime += Time.deltaTime * 10f;
        }else
        {
        
        }
        print (currentTime);
    }
    

    public void ShieldSwitch()
    {
        if(Input.GetKeyDown(KeyCode.Space) && currentTime > cooldownSpeed)
        {
            isAtP1 = !isAtP1;
            currentTime = startTime;
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