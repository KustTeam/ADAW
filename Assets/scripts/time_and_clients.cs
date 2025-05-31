using UnityEngine;
using TMPro;
using System.Collections;


public class time_and_clients : MonoBehaviour
{
    public static int point;
    [SerializeField] private TextMeshProUGUI text;
    private int clients = 0;
    private int max_clients = 2;
    public GameObject client;

    void Start()
    {
        text = GameObject.FindWithTag("Finish").GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        text.text = point.ToString();
    }
    public void Spawn() 
    {
        if (clients == 0)
        {
            clients = max_clients;
            StartCoroutine(SpawnClients());
        }
    }
    
    private IEnumerator SpawnClients()
    {
        for(var i = 0; i < max_clients; i++)
        {
            yield return new WaitForSeconds(0);
            Instantiate(client, transform.position, transform.rotation);
        }
    }

}
