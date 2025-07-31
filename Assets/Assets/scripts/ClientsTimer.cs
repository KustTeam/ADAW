using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClientsTimer : MonoBehaviour
{
    public int timer;
    public static int time = 60;
    public bool readyClients = true;
    public TMPro.TextMeshPro text;
    private DialogClients DialogClients;
    public GameObject head;
    public GameObject body;
    public GameObject grusEat;

    void Start()
    {
        timer = time;
        text = GetComponent<TMPro.TextMeshPro>();
        DialogClients = head.GetComponent<DialogClients>();
        StartCoroutine(TimerCoroutine());
    }


    void Update()
    {
        text.text = timer.ToString();
        if (timer <= 0 || DialogClients.GoodEat == 1 || DialogClients.GoodEat == -1)
        {
            readyClients = false;
            text.text = "";
            if (time_and_clients.endClient == true)
            {
                if (DialogClients.objectEat != null)
                {
                    Instantiate(grusEat, DialogClients.objectEat.transform.position, DialogClients.objectEat.transform.rotation);
                    Destroy(DialogClients.objectEat);
                }
                Destroy(body);
            }
        }
    }
    
    private IEnumerator TimerCoroutine()
    {
        if (readyClients == true)
        {
            while (timer > 0)
            {
                yield return new WaitForSeconds(1f);
                timer -=1;
            }
        }
    }
}
