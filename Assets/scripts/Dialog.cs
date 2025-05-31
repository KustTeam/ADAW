using UnityEngine;

public class Dialog : MonoBehaviour
{
    public GameObject text1;
    private int animText1 = 0;
    public int dialog = 0;
    private float tim = 0f;
    public controle cont;
    private povorot linkPovorot;
    public bool HitTarget = false;
    public Animator anim;
    
    private void Start() 
    {
        GameObject player = GameObject.FindWithTag("Player");
        cont = player.GetComponent<controle>();
        GameObject camera = GameObject.FindWithTag("MainCamera");
        text1 = GameObject.FindWithTag("dialog");
        linkPovorot = camera.GetComponent<povorot>();
    }
    private void Update() 
    {
        if (dialog == 0)
        {
            animText1 = 0;
            cont.enabled = true;
            linkPovorot.enabled = true;
        }
        else if (dialog == 1)
        {
            animText1 = 0;
            cont.enabled = true;
            linkPovorot.enabled = true;
        }
        else if (dialog == 2)
        {
            animText1 = 1;
            cont.enabled = false;
            linkPovorot.enabled = false;
        }
        else if (dialog > 2)
        {
            dialog = 0;
        }

        //анимация диалогов
        if (animText1 == 1)
        {
            anim.SetBool("IsDialogStart", true);
        }
        else if (animText1 == 0)
        {
            anim.SetBool("IsDialogStart", false);
        }
    
        if (HitTarget == true) 
        {
            if (Input.GetKey(KeyCode.E) && tim <= 0f)
            {
                dialog += 1;
                tim = 0.3f;
            }
            if (tim > 0)
            {
                tim = tim - Time.deltaTime;
            }
            if (dialog == 0)
            {
                dialog = 1;
            }    
        }
        else
        {
            dialog = 0;
        }
    }
}