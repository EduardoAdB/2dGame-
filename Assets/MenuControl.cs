using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public Animator animacao;
    bool isopen = false;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)&& isopen==false)
        {
            animacao.SetTrigger("Open");
            isopen = true;
        }

        if(Input.GetKeyDown(KeyCode.X)&& isopen == true)
        {
            animacao.SetTrigger("Close");
            isopen = false;
        }
    }
}
