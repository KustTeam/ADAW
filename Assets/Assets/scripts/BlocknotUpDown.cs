using UnityEngine;

public class BlocknotUpDown : MonoBehaviour
{

    public bool Blockot;
    public GameObject player;
    public controle cont;
    private povorot linkPovorot;
    public muve_off contDialogNow;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
        GameObject camera = GameObject.FindWithTag("MainCamera");
        cont = player.GetComponent<controle>();
        linkPovorot = camera.GetComponent<povorot>();
        GameObject povar = GameObject.FindWithTag("povar");
        contDialogNow = povar.GetComponent<muve_off>();
    }


    void Update()
    {
        if (Blockot == true && transform.position.y < 180)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 130, transform.position.z);
            contDialogNow.dialogNow = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else if (Blockot == false && transform.position.y > -200)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 130, transform.position.z);
            contDialogNow.dialogNow = false;
            Cursor.lockState = CursorLockMode.Locked;
        }
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (Blockot == true)
            {
                Blockot = false;
            }
            else 
            {
                Blockot = true;
            }
        }
    }
}


/*
⠄⠄⣿⣿⣿⣿⠘⡿⢛⣿⣿⣿⣿⣿⣧⢻⣿⣿⠃⠸⣿⣿⣿⠄⠄⠄⠄⠄
⠄⠄⣿⣿⣿⣿⢀⠼⣛⣛⣭⢭⣟⣛⣛⣛⠿⠿⢆⡠⢿⣿⣿⠄⠄⠄⠄⠄
⠄⠄⠸⣿⣿⢣⢶⣟⣿⣖⣿⣷⣻⣮⡿⣽⣿⣻⣖⣶⣤⣭⡉⠄⠄⠄⠄⠄
⠄⠄⠄⢹⠣⣛⣣⣭⣭⣭⣁⡛⠻⢽⣿⣿⣿⣿⢻⣿⣿⣿⣽⡧⡄⠄⠄⠄
⠄⠄⠄⠄⣼⣿⣿⣿⣿⣿⣿⣿⣿⣶⣌⡛⢿⣽⢘⣿⣷⣿⡻⠏⣛⣀⠄⠄
⠄⠄⠄⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣦⠙⡅⣿⠚⣡⣴⣿⣿⣿⡆⠄
⠄⠄⣰⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⠄⣱⣾⣿⣿⣿⣿⣿⣿⠄
⠄⢀⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⢸⣿⣿⣿⣿⣿⣿⣿⣿⠄
⠄⣸⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⠣⣿⣿⣿⣿⣿⣿⣿⣿⣿⠄
⠄⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⠿⠛⠑⣿⣮⣝⣛⠿⠿⣿⣿⣿⣿⠄
⢠⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣶⠄⠄⠄⠄⣿⣿⣿⣿⣿⣿⣿⣿⣿⡟⠄
*/