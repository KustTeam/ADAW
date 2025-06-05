using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDown : MonoBehaviour
{
    private RectTransform rectTransform;
    private Dialog dialogComponent;

    // Верхняя и нижняя границы позиции по Y
    [SerializeField] private float upperY = 100f;   // поднять выше
    [SerializeField] private float lowerY = -240f;

    // Скорость движения (пикселей в секунду)
    [SerializeField] private float moveSpeed = 500f;

    void Start()
    {
        GameObject dialogObject = GameObject.FindWithTag("dialog");
        if (dialogObject != null)
            rectTransform = dialogObject.GetComponent<RectTransform>();
        else
            Debug.LogError("Объект с тегом 'dialog' не найден!");

        GameObject nps = GameObject.FindWithTag("NPSS");
        if (nps != null)
            dialogComponent = nps.GetComponent<Dialog>();
        else
            Debug.LogError("Объект с тегом 'NPSS' не найден!");
    }

    void Update()
    {
        if (rectTransform == null || dialogComponent == null)
            return;

        float targetY;

        if (dialogComponent.dialog < 2)
        {
            // Опускаем до lowerY
            targetY = lowerY;
        }
        else if (dialogComponent.dialog == 2)
        {
            // Поднимаем до upperY
            targetY = upperY;
        }
        else
        {
            // Можно задать другое поведение, например, оставаться на месте
            return;
        }

        Vector2 currentPos = rectTransform.anchoredPosition;
        // Плавно двигаем позицию по Y к targetY с заданной скоростью
        float newY = Mathf.MoveTowards(currentPos.y, targetY, moveSpeed * Time.deltaTime);
        rectTransform.anchoredPosition = new Vector2(currentPos.x, newY);
    }
}