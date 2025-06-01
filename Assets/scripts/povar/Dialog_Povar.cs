using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialog_Povar : MonoBehaviour
{
    public CanvasGroup myCanvasGroup;
    RaycastHit hit;
    [SerializeField] float distance = 7.2f; // Дистанция для луча
    public Dialog cont;
    public muve_off contDialogNow;
    public int moment = 0;
    public Animator anim;
     
    void Start()
    {
        GameObject povar = GameObject.FindWithTag("povar");
        contDialogNow = povar.GetComponent<muve_off>();
    }

    // Update is called once per frame
    void Update()
    {
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
                    moment += 1;
                    if (moment == 1)
                    {
                        contDialogNow.dialogNow = true;
                        anim.SetBool("dialog", true);
                        Cursor.lockState = CursorLockMode.Confined;
                    }
                    else if (moment >= 2)
                    {
                        moment = 0;
                        contDialogNow.dialogNow = false;
                        anim.SetBool("dialog", false);
                        Cursor.lockState = CursorLockMode.Locked;
                    }
                }
            }
            //рука для нпс
            else if (hit.transform.CompareTag("NPS") && DialogClients.PlayerOnTrigger == 1)
            {
                cont.HitTarget = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    myCanvasGroup.alpha = 0;
                }
            }
        }
    }
}