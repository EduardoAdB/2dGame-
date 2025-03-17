using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeaSound : MonoBehaviour
{
    public AudioSource audioSource;

    void Start()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.loop = true; 
            audioSource.Play();
        }
    }
}
