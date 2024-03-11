using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource playSound; //play sound source appears on inspector

    void OnTriggerEnter(Collider other)
    {
        playSound.Play(); 
    }
}

