using System.Collections.Generic;
using UnityEngine;

public class MovementSound : MonoBehaviour
{
    [System.Serializable]
    public class KeySound
    {
        public KeyCode key; 
        public AudioSource audioSource;
    }

    public List<KeySound> keySounds = new List<KeySound>();
    private Dictionary<KeyCode, AudioSource> soundDictionary;

    void Start()
    {
        
        soundDictionary = new Dictionary<KeyCode, AudioSource>();
        foreach (KeySound ks in keySounds)
        {
            soundDictionary[ks.key] = ks.audioSource;
        }
    }

    void Update()
    {
        foreach (var entry in soundDictionary)
        {
            if (Input.GetKeyDown(entry.Key))
            {
                if (!entry.Value.isPlaying)
                {
                    entry.Value.Play();
                }
            }
            else if (Input.GetKeyUp(entry.Key))
            {
                entry.Value.Stop();
            }
        }
    }
}
