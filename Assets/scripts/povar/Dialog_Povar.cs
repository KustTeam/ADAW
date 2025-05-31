using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog_Povar : MonoBehaviour
{
    RaycastHit hit;
    [SerializeField] float distance = 7.2f; // Дистанция для луча
    public CanvasGroup myCanvasGroup;
    public Dialog cont;
    public muve_off contDialogNow;
    public pinkti linkPinkti;
    public int moment = 0;
    public int moment_menu = 0;
    public Animator anim;
    public Animator anim_menu_vibar;
    public Animator anim_menu;

     
    void Start()
    {
        GameObject povar = GameObject.FindWithTag("povar");
        contDialogNow = povar.GetComponent<muve_off>();
        GameObject menu = GameObject.FindWithTag("punkt");
        linkPinkti = menu.GetComponent<pinkti>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moment == 2)
        {
            moment = 0;
            contDialogNow.dialogNow = false;
            anim.SetBool("dialog", false);
            Cursor.lockState = CursorLockMode.Locked;
        }

        //получение доступа
        GameObject NPS = GameObject.FindWithTag("NPS");
        if (NPS != null)
        {
            cont = NPS.GetComponent<Dialog>();
        }
        else
        {
            Debug.LogWarning("Объект с тегом 'NPS' не найден на сцене.");
        }
        
        //взаимодействие с поваром
        cont.HitTarget = false;
        if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
        {
            if (hit.transform.CompareTag("povar"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    moment = 1;
                    if (moment == 1)
                    {
                        contDialogNow.dialogNow = true;
                        anim.SetBool("dialog", true);
                        Cursor.lockState = CursorLockMode.Confined;
                    }
                }
            }
            //рука для нпс
            else if (hit.transform.CompareTag("NPS"))
            {
                cont.HitTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    myCanvasGroup.alpha = 0;
                    Debug.Log("okNPS");
                }
            }
            //подбор меню
            else if (hit.transform.CompareTag("menu"))
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    moment_menu += 1;
                    if(moment_menu == 1)
                    {
                        contDialogNow.dialogNow = true;
                        anim_menu_vibar.SetBool("Is_menu_taked", true);
                        Cursor.lockState = CursorLockMode.Confined;
                        linkPinkti.link = 2;
                    }
                    else if(moment_menu >= 2)
                    {
                        moment_menu = 0;
                        contDialogNow.dialogNow = false;
                        anim_menu_vibar.SetBool("Is_menu_taked", false);
                        anim_menu.SetBool("menu_vibar", false);
                        Cursor.lockState = CursorLockMode.Locked;
                        linkPinkti.link = 1;
                    }
                }
            }
        }
    }
}