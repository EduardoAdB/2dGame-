using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{
    public AudioSource audiosourse;
    public KeyCode keyToPress = KeyCode.F;

    private void Update()
    {
        if (Input.GetKeyDown(keyToPress))
        {
            audiosourse.Play();
        }
    }
}
