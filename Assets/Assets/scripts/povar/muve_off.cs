using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class muve_off : MonoBehaviour
{
    public controle cont;
    private povorot linkPovorot;
    public bool dialogNow = false;
    
    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
        cont = player.GetComponent<controle>();
        GameObject camera = GameObject.FindWithTag("MainCamera");
        linkPovorot = camera.GetComponent<povorot>();
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogNow == true)
        {
            cont.enabled = false;
            linkPovorot.enabled = false;
        }
        else
        {
            cont.enabled = true;
            linkPovorot.enabled = true;
        }
    }
}