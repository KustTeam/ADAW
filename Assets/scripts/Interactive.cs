using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactive : MonoBehaviour
{
    [SerializeField] float distance = 7.2f; // Задайте значение по умолчанию
    RaycastHit hit;
    public bool DoorOpen = false;

    private IEnumerator ExecuteDoorAnimation(Animator anim)
    {
        // Устанавливаем дверь в состояние "открыта"
        anim.SetBool("Open", true);
        DoorOpen = true;

        // Ждем 2 секунды, чтобы анимация завершилась
        yield return new WaitForSeconds(2f);

        // Устанавливаем дверь в состояние "закрыта"
        anim.SetBool("Open", false);
        DoorOpen = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hit, distance))
            {
                Debug.Log(hit.transform.name);
                if (hit.transform.CompareTag("AnimatedDoor"))
                {
                    Animator anim = hit.transform.GetComponent<Animator>();
                    if (!DoorOpen)
                    {
                        StartCoroutine(ExecuteDoorAnimation(anim));
                    }
                }
            }
        }
    }
}