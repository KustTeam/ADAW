using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_no_false : MonoBehaviour
{
    private Dialog_Povar linkDialog_Povar;
    public buttons_off knopki;
    public Animator anim;

    public void Start()
    {
        GameObject cameras = GameObject.FindWithTag("MainCamera");
        linkDialog_Povar = cameras.GetComponent<Dialog_Povar>();
        GameObject button = GameObject.FindWithTag("buttons");
        knopki = button.GetComponent<buttons_off>();
        
    }

    public void okey()
    {
        linkDialog_Povar.moment = 2;
    }
}