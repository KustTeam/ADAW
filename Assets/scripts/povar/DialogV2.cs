using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogV2 : MonoBehaviour
{
    public CanvasGroup myCanvasGroup0; 
    public CanvasGroup myCanvasGroup1; // Ссылка на CanvasGroup
    RaycastHit hit;
    [SerializeField] float distance = 7.2f; // Дистанция для луча

    // Update is called once per frame
    void Update()
    { 
        // Проверяем, попадает ли луч на объект
        if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
        {
            // Проверяем, есть ли тег "NPS" или "NPC"
            if (hit.transform.CompareTag("NPS") || hit.transform.CompareTag("AnimatedDoor") || hit.transform.CompareTag("povar") || hit.transform.CompareTag("menu"))
            {
                // Если попали на NPC или NPS, оставляем alpha = 0 (невидимый)
                myCanvasGroup0.alpha = 0;
                myCanvasGroup1.alpha = 1;
            }
            else
            {
                // Если попали на что-то другое, делаем интерфейс видимым
                myCanvasGroup0.alpha = 1;
                myCanvasGroup1.alpha = 0;
            }
        }
        else
        {
            // Если луч не попадает ни на что, делаем интерфейс видимым
            myCanvasGroup0.alpha = 1;
            myCanvasGroup1.alpha = 0;
        }
    }
}
