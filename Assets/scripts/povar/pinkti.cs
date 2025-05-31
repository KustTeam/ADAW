using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinkti : MonoBehaviour
{
    public CanvasGroup Galochka1;
    public CanvasGroup Galochka2; 
    public bool Is_push1 = false;
    public bool Is_push2 = false;
    public int link = 0;
    public GameObject objectToSpawn_kart;
    public GameObject objectToSpawn_kasha;
    public List<string> bluda = new List<string>();
    public Vector3 spawnPosition1;     // Позиция, где будет заспавнен объект
    public Vector3 spawnPosition2;


    void SpawnObject()
    {
        link = 0;
        for (int i = 0; i < bluda.Count; i++)
        {
            if (i == 0)
            {
                if (bluda[i] == "ж_картошка")
                {
                    Instantiate(objectToSpawn_kart, spawnPosition1, Quaternion.identity);
                }

                if (bluda[i] == "каша")
                {
                    Instantiate(objectToSpawn_kasha, spawnPosition1, Quaternion.identity);
                }
            }
            else if (i == 1)
            {
                if (bluda[i] == "ж_картошка")
                {
                    Instantiate(objectToSpawn_kart, spawnPosition2, Quaternion.identity);
                }

                if (bluda[i] == "каша")
                {
                    Instantiate(objectToSpawn_kasha, spawnPosition2, Quaternion.identity);
                }
            }
        }
    }

    public void жареная_картошка()
    {
        if (Is_push1 == false)
        {
            Is_push1 = true;
            Debug.Log("нажато");
            Galochka1.alpha = 1;
            bluda.Add("ж_картошка");
        }
        else if (Is_push1 == true)
        {
            Is_push1 = false;
            Debug.Log("ne нажато");
            Galochka1.alpha = 0;
            bluda.Remove("ж_картошка");
        }
    }

    public void каша()
    {
        if (Is_push2 == false)
        {
            Is_push2 = true;
            Debug.Log("нажато");
            Galochka2.alpha = 1;
            bluda.Add("каша");
        }
        else if (Is_push2 == true)
        {
            Is_push2 = false;
            Debug.Log("ne нажато");
            Galochka2.alpha = 0;
            bluda.Remove("каша");
        }
    }

    public void Update()
    {
        if (link == 1)
        {
            SpawnObject();
        }

        else if (link == 2)
        {
            link = 0;
            if (Is_push1 == true)
            {
                bluda.Clear();
                Is_push1 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
            }
            else if (Is_push2 == true)
            {
                bluda.Clear();
                Is_push2 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
            }
        }
    }
}
