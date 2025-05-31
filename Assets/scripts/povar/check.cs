using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class check : MonoBehaviour
{
    private button_no oke;
    public Collider triggerCollider; 

    void Start()
    {
        GameObject button = GameObject.FindWithTag("ok");
        oke = button.GetComponent<button_no>();
    }

    void Update()
    {
        // Проверяем все коллайдеры с тегом "Eat" в зоне триггера
        Collider[] hits = Physics.OverlapBox(triggerCollider.bounds.center, triggerCollider.bounds.extents, Quaternion.identity);

        bool eatInside = false;
        foreach (var hit in hits)
        {
            if (hit.CompareTag("Eat"))
            {
                eatInside = true;
                Debug.Log("tyu");
                break;
            }
        }

        // Обновляем переменную bluda в зависимости от наличия еды
        if (oke != null)
        {
            oke.bluda = eatInside;
        }
    }
}