using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_no : MonoBehaviour
{
    public CanvasGroup StartText; 
    public CanvasGroup NoText;
    private Dialog_Povar linkDialog_Povar;

    public void Start()
    {
        GameObject camera = GameObject.FindWithTag("Player");
        linkDialog_Povar = camera.GetComponent<Dialog_Povar>();
    }

    public void Update()
    {
        if (linkDialog_Povar.moment == 0)
        {
            StartCoroutine(Timer());
        }
    }

    public void net()
    {
        StartText.alpha = 0;
        NoText.alpha = 1;
    }

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);
        StartText.alpha = 1;
        NoText.alpha = 0;
    }
}