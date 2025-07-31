using UnityEngine;

public class Tarelki : MonoBehaviour
{
    public static int TarelkiNow = 1;
    public bool TrueFalseTarelki;
    private TMPro.TextMeshPro text;

    void Start() 
    {
        text = GetComponent<TMPro.TextMeshPro>();
    }

    void Update()
    {
        if (TarelkiNow > 0)
        {
            TrueFalseTarelki = true;
        }
        else
        {
            TrueFalseTarelki = false;
        }
        text.text = TarelkiNow.ToString();
    }
}
