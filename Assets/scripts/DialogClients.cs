using System.Collections.Generic;
using System.Collections;
using UnityEngine;
using TMPro;

public class DialogClients : MonoBehaviour
{
    private int FirstEat;
    private int Privet;
    private int macsEat = 10;
    private Transform tran;
    private Transform playerTransform;
    public static int PlayerOnTrigger = 0;
    private ClientsTimer ClientsTimer;
    public GameObject timer;
    public int GoodEat = 0;
    public GameObject objectEat;


    [SerializeField] private TextMeshProUGUI text;

    public List<string> VegEat = new List<string> { "жареную картошку ", "дешёвый салат ", "борщ без мяса (для бедных) ", "недоеденные овощи ", "фруктовый салат ", "просто ягод ", "брокколи с брокколи ", "макароны ", "пюре ", "кашу " };

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
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransform = player.transform;
        ClientsTimer = timer.GetComponent<ClientsTimer>();
    }
    


    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerOnTrigger = 1;
            if (ClientsTimer.readyClients == true && GoodEat == 0)
            {
                text.text = VariantDialog[Privet] + VegEat[FirstEat];
            }
            else if (GoodEat == 1)
            {
                text.text = "Спасибо.";
            }
            else if (GoodEat == -1)
            {
                text.text = "Это не то что я заказывал.";
            }
            else
            {
                text.text = "Можете не беспокоиться, я скоро уйду.";
            }
        }
    }

    private void OnTriggerExit(Collider other) 
    {
        if (other.CompareTag("Player"))
        {
            PlayerOnTrigger = 0;
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        if (other.CompareTag("фруктовый салат") || other.CompareTag("пюре") || other.CompareTag("просто ягоды") || other.CompareTag("недоеденные овощи") || other.CompareTag("макароны") || other.CompareTag("каша") || other.CompareTag("жаренная картошка") || other.CompareTag("дешёвый салат") || other.CompareTag("брокколи с брокколи") || other.CompareTag("борщ без мяса"))
        {
            string objectName = other.gameObject.tag;
            objectEat = other.gameObject;
            if (ClientsTimer.readyClients == true)
            {
                if (FirstEat == 0 && objectName == "жаренная картошка") 
                {
                    Debug.Log("Молодец");
                    GoodEat = 1;
                }
                else if (FirstEat == 8 && objectName == "пюре") 
                {
                    Debug.Log("Молодец");
                    GoodEat = 1;
                }
                else if (FirstEat == 5 && objectName == "просто ягоды") 
                {
                    Debug.Log("Молодец");
                    GoodEat = 1;
                }
                else if (FirstEat == 3 && objectName == "недоеденные овощи") 
                {
                    Debug.Log("Молодец");
                    GoodEat = 1;
                }
                else if (FirstEat == 7 && objectName == "макароны") 
                {
                    Debug.Log("Молодец");
                    GoodEat = 1;
                }
                else if (FirstEat == 9 && objectName == "каша") 
                {
                    Debug.Log("Молодец");
                    GoodEat = 1;
                }
                else if (FirstEat == 4 && objectName == "фруктовый салат") 
                {
                    Debug.Log("Молодец");
                    GoodEat = 1;
                }
                else if (FirstEat == 1 && objectName == "дешёвый салат") 
                {
                    Debug.Log("Молодец");
                    GoodEat = 1;
                }
                else if (FirstEat == 6 && objectName == "брокколи с брокколи") 
                {
                    Debug.Log("Молодец");
                    GoodEat = 1;
                }
                else if (FirstEat == 2 && objectName == "борщ без мяса") 
                {
                    Debug.Log("Молодец");
                    GoodEat = 1;
                }
                else
                {
                    Debug.Log("Ты дебил");
                    GoodEat = -1;
                }
                other.gameObject.tag = "Eat";
            }
        }
    }
}