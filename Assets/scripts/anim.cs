using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class anim : MonoBehaviour
{
    public Animator animation;
    public bool check;

    void Update()
    {
        if (check == false)
        {
            animation.SetBool("IsDialogStart", false);
        }
        else if (check == true)
        {
            animation.SetBool("IsDialogStart", true);
        }
    }
}
