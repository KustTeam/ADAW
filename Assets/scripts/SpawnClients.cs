using System.Collections.Generic;
using System.Collections;
using UnityEngine;


public class SpawnClients : MonoBehaviour
{
    private int Spawn;
    private Transform tran;
    private int x;
    public GameObject timer;
    private bool Gotov = false;
    private ClientsTimer ClientsTimer;
    private DialogClients DialogClients;
    public GameObject head;
    private bool y = false;

    void Start()
    {
        tran = GetComponent<Transform>();
        DialogClients = head.GetComponent<DialogClients>();
        Spawn = Random.Range(1, 10); // Изменено на 10, чтобы включить 
        x = Random.Range(0, 2);
        StartCoroutine(SpawnCl());
        ClientsTimer = timer.GetComponent<ClientsTimer>();
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("NPS"))
        {
            Spawn = Random.Range(1, 10); // Генерируем новую позицию
            x = Random.Range(0, 2);
            StartCoroutine(SpawnCl());
        }

    }
    private void Update() 
    {
        if (ClientsTimer.readyClients == false)
        {
            Gotov = true;
            if (DialogClients.GoodEat == 1)
            {
                if (y == false)
                {
                    time_and_clients.clients -= 1;
                    time_and_clients.point += 10;
                    y = true;
                }
            }
            if (DialogClients.GoodEat == -1)
            {
                if (y == false)
                {
                    time_and_clients.clients -= 1;
                    y = true;
                }
            }
            if (ClientsTimer.timer <= 0)
            {
                if (y == false)
                {
                    time_and_clients.clients -= 1;
                    y = true;
                }
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
