using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

public class DialogClients : MonoBehaviour
{
    private int FirstEat;
    private int Privet;
    private int Spawn;
    private int macsEat = 10;
    private Transform tran;
    private int x;

    [SerializeField] private TextMeshProUGUI text;

    public List<string> VegEat = new List<string> { "жареную картошку ", "дешёвый салат ", "борщ без мяса (для бедных) ", "недоеденные овощи ", "фруктовый салат ", "просто ягоды ", "брокколи с брокколи ", "макароны ", "пюре ", "кашу " };

    public List<string> VariantDialog = new List<string>
    {
        "Афицант! Принеси мне ",
        "Я хочу сегодня поесть ",
        "Слышь лентяй, принеси сюда ",
        "Эй ты, я хочу пожрать ",
        "Я давно не ел ",
        "У меня хватает денег только на ",
        "У вас повар очень вкусно готовит ",
        "*свист* сюда подойди! Принеси мне ",
        "Я сегодня шикую, поэтому принеси мне ",
        "Я умру если не съем сегодня "
    };

    

    void Start()
    {
        FirstEat = Random.Range(0, macsEat);
        text = GameObject.FindWithTag("TextDialog").GetComponent<TextMeshProUGUI>();
        tran = GetComponent<Transform>();
        Privet = Random.Range(0, VariantDialog.Count);
        Spawn = Random.Range(1, 10); // Изменено на 10, чтобы включить 
        x = Random.Range(0, 2);
        StartCoroutine(SpawnCl());
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            text.text = VariantDialog[Privet] + VegEat[FirstEat];
        }

        if (other.CompareTag("NPS"))
        {
                Spawn = Random.Range(1, 10); // Генерируем новую позицию
                x = Random.Range(0, 2);
                StartCoroutine(SpawnCl());
        }

    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("Eat"))
        {
            string objectName = other.gameObject.name;

            if (objectName == VegEat[FirstEat])
            {
                Debug.Log("Молодец");
            }
            else
            {
                Debug.Log("Ты дебил");
            }
        }
    }
    private IEnumerator SpawnCl()
    {
        if (x == 0)
        {
            x = 4;
            tran.eulerAngles = new Vector3(0, 180, 0);
        }
        else if (x == 1)
        {
            x = -4;
            tran.eulerAngles = new Vector3(0, 0, 0);
        }
        // Определяем позицию в зависимости от значения Spawn
        Vector3 newPosition = Vector3.zero;
        switch (Spawn)
        {
            case 1: newPosition = new Vector3(x, 2.5f, -10); break;
            case 2: newPosition = new Vector3(x, 2.5f, -25); break;
            case 3: newPosition = new Vector3(x, 2.5f, -40); break;
            case 4: newPosition = new Vector3(x + 20, 2.5f, -10); break;
            case 5: newPosition = new Vector3(x + 20, 2.5f, -25); break;
            case 6: newPosition = new Vector3(x + 20, 2.5f, -40); break;
            case 7: newPosition = new Vector3(x - 20, 2.5f, -10); break;
            case 8: newPosition = new Vector3(x - 20, 2.5f, -25); break;
            case 9: newPosition = new Vector3(x - 20, 2.5f, -40); break;
        }

        tran.position = newPosition;
        yield return new WaitForSeconds(0);
    }
}