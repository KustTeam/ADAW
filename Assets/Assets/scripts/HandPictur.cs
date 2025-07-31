using UnityEngine;
using UnityEngine.UI;

public class HandPictur : MonoBehaviour
{

    private RawImage imag;

    void Start()
    {
        imag = GetComponent<RawImage>();
    }

    void Update()
    {
        if (Take.eatAtHand != null)
        {
            imag.enabled = true;
            if (Take.eatAtHand == "жаренная картошка")
            {
                imag.texture = Resources.Load<Texture>("Textur/Eat2D/Жареная картофан");
            }
            if (Take.eatAtHand == "дешёвый салат")
            {
                imag.texture = Resources.Load<Texture>("Textur/Eat2D/Салат дешёвый");
            }
            if (Take.eatAtHand == "борщ без мяса")
            {
                imag.texture = Resources.Load<Texture>("Textur/Eat2D/борщ");
            }
            if (Take.eatAtHand == "брокколи с брокколи")
            {
                imag.texture = Resources.Load<Texture>("Textur/Eat2D/Броколли с броколли");
            }
            if (Take.eatAtHand == "каша")
            {
                imag.texture = Resources.Load<Texture>("Textur/Eat2D/каша");
            }
            if (Take.eatAtHand == "макароны")
            {
                imag.texture = Resources.Load<Texture>("Textur/Eat2D/макароны");
            }
            if (Take.eatAtHand == "недоеденные овощи")
            {
                imag.texture = Resources.Load<Texture>("Textur/Eat2D/Недоеденые овощи");
            }
            if (Take.eatAtHand == "просто ягоды")
            {
                imag.texture = Resources.Load<Texture>("Textur/Eat2D/Просто ягоды");
            }
            if (Take.eatAtHand == "пюре")
            {
                imag.texture = Resources.Load<Texture>("Textur/Eat2D/пюре");
            }
            if (Take.eatAtHand == "фруктовый салат")
            {
                imag.texture = Resources.Load<Texture>("Textur/Eat2D/фруктовый салат");
            }
            if (Take.eatAtHand == "gras")
            {
                imag.texture = Resources.Load<Texture>("Textur/Eat2D/гряхная");
            }
        }
        else
        {
            imag.enabled = false;
        }
    }
}
