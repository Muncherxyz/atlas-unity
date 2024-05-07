using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinTrigger : MonoBehaviour
{
    public AudioSource winPiano;
    public AudioSource cheeryBackground;
    void OnTriggerEnter(Collider other)
    {
        Timer timerStamp = other.GetComponent<Timer>();
        if (timerStamp != null)
            timerStamp.enabled = false;
            winPiano.enabled = true;
            cheeryBackground.enabled = false;
    }
}
