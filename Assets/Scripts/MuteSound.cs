using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuteSound : MonoBehaviour
{
    AudioSource audioSource;
    public bool alreadyTriggered;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!alreadyTriggered)
        {
            audioSource.mute = !audioSource.mute;
            alreadyTriggered = true;
        }
    }
}