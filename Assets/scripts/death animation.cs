using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deathanimation : MonoBehaviour
{
    public Animator animator;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            animator.SetTrigger("Die");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("Undie");
        }
    }
}
