using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEngine;

public class MenuControl : MonoBehaviour
{
    public Animator animacao;
    bool isopen = true;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X)&& isopen==false)
        {
            animacao.SetTrigger("Open");
            isopen = true;
            Debug.Log("abriu");
        }

        if(Input.GetKeyDown(KeyCode.C)&& isopen == true)
        {
            animacao.SetTrigger("Close");
            isopen = false;
            Debug.Log("fechou");
        }
    }
}
