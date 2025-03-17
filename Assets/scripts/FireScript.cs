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
            animator.SetBool("Shoot 0", true);
            StartCoroutine(ResetShootAfterAnimation());
        }

    } 
    private IEnumerator ResetShootAfterAnimation()
    {
        AnimatorStateInfo stateInfo = animator.GetCurrentAnimatorStateInfo(0);
        float animationTime = stateInfo.length;

        yield return new WaitForSeconds(animationTime);

        animator.SetBool("Shoot 0", false);
    }
    
}
