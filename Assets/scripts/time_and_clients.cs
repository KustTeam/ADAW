using UnityEngine;
using TMPro;
using System.Collections;


public class time_and_clients : MonoBehaviour
{
    public static int point = 0;
    [SerializeField] private TextMeshProUGUI text;
    public static int clients = 0;
    private int max_clients = 1;
    public GameObject client;
    public static bool endClient = false;
    private bool x = false;

    void Start()
    {
        text = GameObject.FindWithTag("Finish").GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        text.text = point.ToString();


        if (x == true)
        {
            if (clients == 0)
            {
                endClient = true;
                clients = max_clients;
                StartCoroutine(SpawnClients());
            }
            else if (clients > 0)
            {
                x = false;
                endClient = false;
            }
        }
        

        if (point >= 10 && point < 500)
        {
            max_clients = 2;
        } 
        if (point >= 50 && point < 80)
        {
            max_clients = 3;
        } 
        if (point >= 80 && point < 120)
        {
            ClientsTimer.time = 45;
            max_clients = 3;
        } 
        if (point >= 120 && point < 250)
        {
            max_clients = 4;
            ClientsTimer.time = 45;
        } 
        if (point >= 250 && point < 500)
        {
            max_clients = 6;
            ClientsTimer.time = 45;
        } 
        if (point >= 500 && point < 750)
        {
            max_clients = 6;
            ClientsTimer.time = 30;
        } 
        if (point >= 750 && point < 1200)
        {
            max_clients = 9;
        } 
        if (point >= 1200 && point < 3000)
        {
            max_clients = 9;
            ClientsTimer.time = 45;
        } 
        if (point >= 3000)
        {
            max_clients = 9;
            ClientsTimer.time = 30;
        } 
    }


    public void Spawn() 
    {
        if (clients == 0)
        {
            x = true;
        }
        else if (clients > 0)
        {
            endClient = false;
            x = false;
        }
    }
    
    private IEnumerator SpawnClients()
    {
        for(var i = 0; i < max_clients; i++)
        {
            Instantiate(client, transform.position, transform.rotation);
            yield return new WaitForSeconds(0);
        }
    }

}
