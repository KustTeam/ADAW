using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttons_off : MonoBehaviour
{
    public bool Press = false;
    public GameObject objectToDisable;

    public void Start()
    {
        objectToDisable = GameObject.Find("buttons");
    }

    void Update()
    {
        if (Press == true)
        {
            if (objectToDisable != null)
            {
                objectToDisable.SetActive(false); // Отключаем объект
            }
            //gameObject.SetActive(false);
        }
        else if (Press == false)
        {
            if (objectToDisable != null)
            {
                objectToDisable.SetActive(true); // Отключаем объект
            }
            //gameObject.SetActive(true);
        }
    }
}
