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
        // Обработка состояния диалога
        if (dialog > 2)
        {
            dialog = 0; // Сброс состояния
        }

        switch (dialog)
        {
            case 0:
                animText1 = 0;
                cont.enabled = true;
                linkPovorot.enabled = true;
                break;

            case 1:
                animText1 = 0;
                cont.enabled = true;
                linkPovorot.enabled = true;
                break;

            case 2:
                animText1 = 1;
                cont.enabled = false;
                linkPovorot.enabled = false;
                break;

        }


        if (anim != null) // Убедитесь, что anim не равен null
        {
            anim.SetBool("IsDialogStart", animText1 == 1);
        }

        if (HitTarget) 
        {
            if (Input.GetKey(KeyCode.E) && tim <= 0f)
            {
                dialog++;
                tim = 0.3f; // Задержка между нажатиями
            }
            
            if (tim > 0)
            {
                tim -= Time.deltaTime; // Уменьшаем таймер
            }
            
            if (dialog == 0)
            {
                dialog++; // Начинаем диалог с первого состояния
            }    
        }
        
        if (!HitTarget)
        {
            dialog = 0; // Сброс состояния при выходе из зоны взаимодействия
        }
    }
}