using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pinkti : MonoBehaviour
{
    public CanvasGroup Galochka1;
    public CanvasGroup Galochka2; 
    public CanvasGroup Galochka3; 
    public CanvasGroup Galochka4; 
    public CanvasGroup Galochka5; 
    public CanvasGroup Galochka6;
    public CanvasGroup Galochka7; 
    public CanvasGroup Galochka8; 
    public CanvasGroup Galochka9; 
    public CanvasGroup Galochka10; 
    public bool Is_push1 = false;
    public bool Is_push2 = false;
    public bool Is_push3 = false;
    public bool Is_push4 = false;
    public bool Is_push5 = false;
    public bool Is_push6 = false;
    public bool Is_push7 = false;
    public bool Is_push8 = false;
    public bool Is_push9 = false;
    public bool Is_push10 = false;
    public int link = 0;
    public bool false_count;
    public GameObject objectToSpawn_kart;
    public GameObject objectToSpawn_kasha;
    public GameObject objectToSpawn_fr_salat;
    public GameObject objectToSpawn_borch;
    public GameObject objectToSpawn_brokkoli;
    public GameObject objectToSpawn_desh_salat;
    public GameObject objectToSpawn_makaroni;
    public GameObject objectToSpawn_ovoshi;
    public GameObject objectToSpawn_yagodu;
    public GameObject objectToSpawn_pure;
    public List<string> bluda = new List<string>();
    public Vector3 spawnPosition1;     // Позиция, где будет заспавнен объект
    public Vector3 spawnPosition2;
    public Vector3 spawnPosition3;
    public Vector3 spawnPosition4;

    void SpawnObject()
    {
        link = 0;
        for (int i = 0; i < bluda.Count; i++)
        {
            if (bluda.Count <=4)
            {
                if (i == 0)
                {
                    StartCoroutine(timer1(i));
                }

                else if (i == 1)
                {
                    StartCoroutine(timer2(i));
                }

                else if (i == 2)
                {
                    StartCoroutine(timer3(i));
                }

                else if (i == 3)
                {
                    StartCoroutine(timer4(i));
                }
            }
            else
            {
                false_count = true;
            }
        }
    }

    public void жареная_картошка()
    {
        if (Tarelki.TarelkiNow > 0)
        {
            if (Is_push1 == false)
            {
                Is_push1 = true;
                Debug.Log("нажато");
                Tarelki.TarelkiNow -= 1;
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
    }

    public void каша()
    {
        if (Tarelki.TarelkiNow > 0)
        {
            if (Is_push2 == false)
            {
                Is_push2 = true;
                Debug.Log("нажато");
                Tarelki.TarelkiNow -= 1;
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
    }

    public void фруктовый_салат()
    {
        if (Tarelki.TarelkiNow > 0)
        {
            if (Is_push3 == false)
            {
                Is_push3 = true;
                Debug.Log("нажато");
                Galochka3.alpha = 1;
                Tarelki.TarelkiNow -= 1;
                bluda.Add("ф_салат");
            }
            else if (Is_push3 == true)
            {
                Is_push3 = false;
                Debug.Log("ne нажато");
                Galochka3.alpha = 0;
                bluda.Remove("ф_салат");
            }
        }
    }

    public void борщь()
    {
        if (Tarelki.TarelkiNow > 0)
        {
            if (Is_push4 == false)
            {
                Is_push4 = true;
                Debug.Log("нажато");
                Tarelki.TarelkiNow -= 1;
                Galochka4.alpha = 1;
                bluda.Add("борщь");
            }
            else if (Is_push4 == true)
            {
                Is_push4 = false;
                Debug.Log("ne нажато");
                Galochka4.alpha = 0;
                bluda.Remove("борщь");
            }
        }
    }

    public void брокколи()
    {
        if (Tarelki.TarelkiNow > 0)
        {
            if (Is_push5 == false)
            {
                Is_push5 = true;
                Debug.Log("нажато");
                Tarelki.TarelkiNow -= 1;
                Galochka5.alpha = 1;
                bluda.Add("брокколи");
            }
            else if (Is_push5 == true)
            {
                Is_push5 = false;
                Debug.Log("ne нажато");
                Galochka5.alpha = 0;
                bluda.Remove("брокколи");
            }
        }
    }

    public void дешевый_салат()
    {
        if (Tarelki.TarelkiNow > 0)
        {
            if (Is_push6 == false)
            {
                Is_push6 = true;
                Debug.Log("нажато");
                Tarelki.TarelkiNow -= 1;
                Galochka6.alpha = 1;
                bluda.Add("д_салат");
            }
            else if (Is_push6 == true)
            {
                Is_push6 = false;
                Debug.Log("ne нажато");
                Galochka6.alpha = 0;
                bluda.Remove("д_салат");
            }
        }
    }

    public void макароны()
    {
        if (Tarelki.TarelkiNow > 0)
        {
            if (Is_push7 == false)
            {
                Is_push7 = true;
                Debug.Log("нажато");
                Tarelki.TarelkiNow -= 1;
                Galochka7.alpha = 1;
                bluda.Add("макароны");
            }
            else if (Is_push7 == true)
            {
                Is_push7 = false;
                Debug.Log("ne нажато");
                Galochka7.alpha = 0;
                bluda.Remove("макароны");
            }
        }
    }

    public void овощи()
    {
        if (Tarelki.TarelkiNow > 0)
        {
            if (Is_push8 == false)
            {
                Is_push8 = true;
                Debug.Log("нажато");
                Tarelki.TarelkiNow -= 1;
                Galochka8.alpha = 1;
                bluda.Add("овощи");
            }
            else if (Is_push8 == true)
            {
                Is_push8 = false;
                Debug.Log("ne нажато");
                Galochka8.alpha = 0;
                bluda.Remove("овощи");
            }
        }
    }

    public void ягоды()
    {
        if (Tarelki.TarelkiNow > 0)
        {
            if (Is_push9 == false)
            {
                Is_push9 = true;
                Debug.Log("нажато");
                Tarelki.TarelkiNow -= 1;
                Galochka9.alpha = 1;
                bluda.Add("ягоды");
            }
            else if (Is_push9 == true)
            {
                Is_push9 = false;
                Debug.Log("ne нажато");
                Galochka9.alpha = 0;
                bluda.Remove("ягоды");
            }
        }
    }

    public void пюре()
    {
        if (Tarelki.TarelkiNow > 0)
        {
            if (Is_push10 == false)
            {
                Is_push10 = true;
                Debug.Log("нажато");
                Tarelki.TarelkiNow -= 1;
                Galochka10.alpha = 1;
                bluda.Add("пюре");
            }
            else if (Is_push10 == true)
            {
                Is_push10 = false;
                Debug.Log("ne нажато");
                Galochka10.alpha = 0;
                bluda.Remove("пюре");
            }
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
                Is_push2 = false;
                Is_push3 = false;
                Is_push4 = false;
                Is_push5 = false;
                Is_push6 = false;
                Is_push7 = false;
                Is_push8 = false;
                Is_push9 = false;
                Is_push10 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
                Galochka3.alpha = 0;
                Galochka4.alpha = 0;
                Galochka5.alpha = 0;
                Galochka6.alpha = 0;
                Galochka7.alpha = 0;
                Galochka8.alpha = 0;
                Galochka9.alpha = 0;
                Galochka10.alpha = 0;
            }
            else if (Is_push2 == true)
            {
                bluda.Clear();
                Is_push1 = false;
                Is_push2 = false;
                Is_push3 = false;
                Is_push4 = false;
                Is_push5 = false;
                Is_push6 = false;
                Is_push7 = false;
                Is_push8 = false;
                Is_push9 = false;
                Is_push10 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
                Galochka3.alpha = 0;
                Galochka4.alpha = 0;
                Galochka5.alpha = 0;
                Galochka6.alpha = 0;
                Galochka7.alpha = 0;
                Galochka8.alpha = 0;
                Galochka9.alpha = 0;
                Galochka10.alpha = 0;
            }
            else if (Is_push3 == true)
            {
                bluda.Clear();
                Is_push1 = false;
                Is_push2 = false;
                Is_push3 = false;
                Is_push4 = false;
                Is_push5 = false;
                Is_push6 = false;
                Is_push7 = false;
                Is_push8 = false;
                Is_push9 = false;
                Is_push10 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
                Galochka3.alpha = 0;
                Galochka4.alpha = 0;
                Galochka5.alpha = 0;
                Galochka6.alpha = 0;
                Galochka7.alpha = 0;
                Galochka8.alpha = 0;
                Galochka9.alpha = 0;
                Galochka10.alpha = 0;
            }
            else if (Is_push4 == true)
            {
                bluda.Clear();
                Is_push1 = false;
                Is_push2 = false;
                Is_push3 = false;
                Is_push4 = false;
                Is_push5 = false;
                Is_push6 = false;
                Is_push7 = false;
                Is_push8 = false;
                Is_push9 = false;
                Is_push10 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
                Galochka3.alpha = 0;
                Galochka4.alpha = 0;
                Galochka5.alpha = 0;
                Galochka6.alpha = 0;
                Galochka7.alpha = 0;
                Galochka8.alpha = 0;
                Galochka9.alpha = 0;
                Galochka10.alpha = 0;
            }
            else if (Is_push5 == true)
            {
                bluda.Clear();
                Is_push1 = false;
                Is_push2 = false;
                Is_push3 = false;
                Is_push4 = false;
                Is_push5 = false;
                Is_push6 = false;
                Is_push7 = false;
                Is_push8 = false;
                Is_push9 = false;
                Is_push10 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
                Galochka3.alpha = 0;
                Galochka4.alpha = 0;
                Galochka5.alpha = 0;
                Galochka6.alpha = 0;
                Galochka7.alpha = 0;
                Galochka8.alpha = 0;
                Galochka9.alpha = 0;
                Galochka10.alpha = 0;
            }
            else if (Is_push6 == true)
            {
                bluda.Clear();
                Is_push1 = false;
                Is_push2 = false;
                Is_push3 = false;
                Is_push4 = false;
                Is_push5 = false;
                Is_push6 = false;
                Is_push7 = false;
                Is_push8 = false;
                Is_push9 = false;
                Is_push10 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
                Galochka3.alpha = 0;
                Galochka4.alpha = 0;
                Galochka5.alpha = 0;
                Galochka6.alpha = 0;
                Galochka7.alpha = 0;
                Galochka8.alpha = 0;
                Galochka9.alpha = 0;
                Galochka10.alpha = 0;
            }
            else if (Is_push7 == true)
            {
                bluda.Clear();
                Is_push1 = false;
                Is_push2 = false;
                Is_push3 = false;
                Is_push4 = false;
                Is_push5 = false;
                Is_push6 = false;
                Is_push7 = false;
                Is_push8 = false;
                Is_push9 = false;
                Is_push10 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
                Galochka3.alpha = 0;
                Galochka4.alpha = 0;
                Galochka5.alpha = 0;
                Galochka6.alpha = 0;
                Galochka7.alpha = 0;
                Galochka8.alpha = 0;
                Galochka9.alpha = 0;
                Galochka10.alpha = 0;
            }
            else if (Is_push8 == true)
            {
                bluda.Clear();
                Is_push1 = false;
                Is_push2 = false;
                Is_push3 = false;
                Is_push4 = false;
                Is_push5 = false;
                Is_push6 = false;
                Is_push7 = false;
                Is_push8 = false;
                Is_push9 = false;
                Is_push10 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
                Galochka3.alpha = 0;
                Galochka4.alpha = 0;
                Galochka5.alpha = 0;
                Galochka6.alpha = 0;
                Galochka7.alpha = 0;
                Galochka8.alpha = 0;
                Galochka9.alpha = 0;
                Galochka10.alpha = 0;
            }
            else if (Is_push9 == true)
            {
                bluda.Clear();
                Is_push1 = false;
                Is_push2 = false;
                Is_push3 = false;
                Is_push4 = false;
                Is_push5 = false;
                Is_push6 = false;
                Is_push7 = false;
                Is_push8 = false;
                Is_push9 = false;
                Is_push10 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
                Galochka3.alpha = 0;
                Galochka4.alpha = 0;
                Galochka5.alpha = 0;
                Galochka6.alpha = 0;
                Galochka7.alpha = 0;
                Galochka8.alpha = 0;
                Galochka9.alpha = 0;
                Galochka10.alpha = 0;
            }
            else if (Is_push10 == true)
            {
                bluda.Clear();
                Is_push1 = false;
                Is_push2 = false;
                Is_push3 = false;
                Is_push4 = false;
                Is_push5 = false;
                Is_push6 = false;
                Is_push7 = false;
                Is_push8 = false;
                Is_push9 = false;
                Is_push10 = false;
                Galochka1.alpha = 0;
                Galochka2.alpha = 0;
                Galochka3.alpha = 0;
                Galochka4.alpha = 0;
                Galochka5.alpha = 0;
                Galochka6.alpha = 0;
                Galochka7.alpha = 0;
                Galochka8.alpha = 0;
                Galochka9.alpha = 0;
                Galochka10.alpha = 0;
            }
        }
    }

    private IEnumerator timer1(int index1)
    {
        string item1 = bluda[index1];

        if (item1 == "ж_картошка")
        {
            yield return new WaitForSeconds(3f);
            Instantiate(objectToSpawn_kart, spawnPosition1, Quaternion.identity);
        }

        if (item1 == "каша")
        {
            yield return new WaitForSeconds(3f);
            Instantiate(objectToSpawn_kasha, spawnPosition1, Quaternion.identity);
        }

        if (item1 == "ф_салат")
        {
            yield return new WaitForSeconds(3f);
            Instantiate(objectToSpawn_fr_salat, spawnPosition1, Quaternion.identity);
        }
        if (item1 == "борщь")
        {
            yield return new WaitForSeconds(3f);
            Instantiate(objectToSpawn_borch, spawnPosition1, Quaternion.identity);
        }

        if (item1 == "брокколи")
        {
            yield return new WaitForSeconds(3f);
            Instantiate(objectToSpawn_brokkoli, spawnPosition1, Quaternion.identity);
        }
        
        if (item1 == "д_салат")
        {
            yield return new WaitForSeconds(3f);
            Instantiate(objectToSpawn_desh_salat, spawnPosition1, Quaternion.identity);
        }

        if (item1 == "макароны")
        {
            yield return new WaitForSeconds(3f);
            Instantiate(objectToSpawn_makaroni, spawnPosition1, Quaternion.identity);
        }
        
        if (item1 == "овощи")
        {
            yield return new WaitForSeconds(3f);
            Instantiate(objectToSpawn_ovoshi, spawnPosition1, Quaternion.identity);
        }

        if (item1 == "ягоды")
        {
            yield return new WaitForSeconds(3f);
            Instantiate(objectToSpawn_yagodu, spawnPosition1, Quaternion.identity);
        }

        if (item1 == "пюре")
        {
            yield return new WaitForSeconds(3f);
            Tarelki.TarelkiNow -= 1;
            Instantiate(objectToSpawn_pure, spawnPosition1, Quaternion.identity);
        }
    }

    private IEnumerator timer2(int index2)
    {
        string item2 = bluda[index2];

        if (item2 == "ж_картошка")
        {
            yield return new WaitForSeconds(6f);
            Instantiate(objectToSpawn_kart, spawnPosition2, Quaternion.identity);
        }

        if (item2 == "каша")
        {
            yield return new WaitForSeconds(6f);
            Instantiate(objectToSpawn_kasha, spawnPosition2, Quaternion.identity);
        }

        if (item2 == "ф_салат")
        {
            yield return new WaitForSeconds(6f);
            Instantiate(objectToSpawn_fr_salat, spawnPosition2, Quaternion.identity);
        }
        if (item2 == "борщь")
        {
            yield return new WaitForSeconds(6f);
            Instantiate(objectToSpawn_borch, spawnPosition2, Quaternion.identity);
        }

        if (item2 == "брокколи")
        {
            yield return new WaitForSeconds(6f);
            Instantiate(objectToSpawn_brokkoli, spawnPosition2, Quaternion.identity);
        }
        
        if (item2 == "д_салат")
        {
            yield return new WaitForSeconds(6f);
            Instantiate(objectToSpawn_desh_salat, spawnPosition2, Quaternion.identity);
        }

        if (item2 == "макароны")
        {
            yield return new WaitForSeconds(6f);
            Instantiate(objectToSpawn_makaroni, spawnPosition2, Quaternion.identity);
        }
        
        if (item2 == "овощи")
        {
            yield return new WaitForSeconds(6f);
            Instantiate(objectToSpawn_ovoshi, spawnPosition2, Quaternion.identity);
        }

        if (item2 == "ягоды")
        {
            yield return new WaitForSeconds(6f);
            Instantiate(objectToSpawn_yagodu, spawnPosition2, Quaternion.identity);
        }

        if (item2 == "пюре")
        {
            yield return new WaitForSeconds(6f);
            Instantiate(objectToSpawn_pure, spawnPosition2, Quaternion.identity);
        }
    }

    private IEnumerator timer3(int index3)
    {
        string item3 = bluda[index3];

        if (item3 == "ж_картошка")
        {
            yield return new WaitForSeconds(9f);
            Instantiate(objectToSpawn_kart, spawnPosition3, Quaternion.identity);
        }

        if (item3 == "каша")
        {
            yield return new WaitForSeconds(9f);
            Instantiate(objectToSpawn_kasha, spawnPosition3, Quaternion.identity);
        }

        if (item3 == "ф_салат")
        {
            yield return new WaitForSeconds(9f);
            Instantiate(objectToSpawn_fr_salat, spawnPosition3, Quaternion.identity);
        }
        if (item3 == "борщь")
        {
            yield return new WaitForSeconds(9f);
            Instantiate(objectToSpawn_borch, spawnPosition3, Quaternion.identity);
        }

        if (item3 == "брокколи")
        {
            yield return new WaitForSeconds(9f);
            Instantiate(objectToSpawn_brokkoli, spawnPosition3, Quaternion.identity);
        }
        
        if (item3 == "д_салат")
        {
            yield return new WaitForSeconds(9f);
            Tarelki.TarelkiNow -= 1;
            Instantiate(objectToSpawn_desh_salat, spawnPosition3, Quaternion.identity);
        }

        if (item3 == "макароны")
        {
            yield return new WaitForSeconds(9f);
            Instantiate(objectToSpawn_makaroni, spawnPosition3, Quaternion.identity);
        }
        
        if (item3 == "овощи")
        {
            yield return new WaitForSeconds(9f);
            Instantiate(objectToSpawn_ovoshi, spawnPosition3, Quaternion.identity);
        }

        if (item3 == "ягоды")
        {
            yield return new WaitForSeconds(9f);
            Instantiate(objectToSpawn_yagodu, spawnPosition3, Quaternion.identity);
        }

        if (item3 == "пюре")
        {
            yield return new WaitForSeconds(9f);
            Instantiate(objectToSpawn_pure, spawnPosition3, Quaternion.identity);
        }
    }

    private IEnumerator timer4(int index4)
    {
        string item4 = bluda[index4];

        if (item4 == "ж_картошка")
        {
            yield return new WaitForSeconds(12f);
            Instantiate(objectToSpawn_kart, spawnPosition4, Quaternion.identity);
        }

        if (item4 == "каша")
        {
            yield return new WaitForSeconds(12f);
            Instantiate(objectToSpawn_kasha, spawnPosition4, Quaternion.identity);
        }

        if (item4 == "ф_салат")
        {
            yield return new WaitForSeconds(12f);
            Instantiate(objectToSpawn_fr_salat, spawnPosition4, Quaternion.identity);
        }
        if (item4 == "борщь")
        {
            yield return new WaitForSeconds(12f);
            Instantiate(objectToSpawn_borch, spawnPosition4, Quaternion.identity);
        }

        if (item4 == "брокколи")
        {
            yield return new WaitForSeconds(12f);
            Instantiate(objectToSpawn_brokkoli, spawnPosition4, Quaternion.identity);
        }
        
        if (item4 == "д_салат")
        {
            yield return new WaitForSeconds(12f);
            Instantiate(objectToSpawn_desh_salat, spawnPosition4, Quaternion.identity);
        }

        if (item4 == "макароны")
        {
            yield return new WaitForSeconds(12f);
            Instantiate(objectToSpawn_makaroni, spawnPosition4, Quaternion.identity);
        }
        
        if (item4 == "овощи")
        {
            yield return new WaitForSeconds(12f);
            Instantiate(objectToSpawn_ovoshi, spawnPosition4, Quaternion.identity);
        }

        if (item4 == "ягоды")
        {
            yield return new WaitForSeconds(12f);
            Instantiate(objectToSpawn_yagodu, spawnPosition4, Quaternion.identity);
        }

        if (item4 == "пюре")
        {
            yield return new WaitForSeconds(12f);
            Instantiate(objectToSpawn_pure, spawnPosition4, Quaternion.identity);
        }
    }
}
