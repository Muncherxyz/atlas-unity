using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerTrigger : MonoBehaviour
{
    private Timer timerScript;
    private bool startTimer;

    private void Start()
    {
        timerScript = FindObjectOfType<Timer>();
        startTimer = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            startTimer = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (startTimer)
            {
                timerScript.enabled = true;
            }
        }
    }
    
}
