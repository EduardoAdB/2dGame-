using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    public Animator animator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger("Fire");
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            animator.SetTrigger("Unfire");
        }
    }
}
