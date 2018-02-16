using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Volume : MonoBehaviour {

    public AudioMixer audioMixer;

    public void SetVolum (float volume)
    {
        audioMixer.SetFloat("volumeM", volume);
    }

}
