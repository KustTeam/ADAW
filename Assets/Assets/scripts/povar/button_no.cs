using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class button_no : MonoBehaviour
{
    public CanvasGroup StartText; 
    public CanvasGroup NoText;
    public CanvasGroup DaText;
    public CanvasGroup Menu_Text;
    public CanvasGroup Menu_false_Text;
    private Dialog_Povar linkDialog_Povar;
    public buttons_off knopki;
    public Animator anim;
    public bool bluda;
    public GameObject TextObject;
    private TextMeshProUGUI text1;

    public void Start()
    {
        GameObject camera = GameObject.FindWithTag("MainCamera");
        linkDialog_Povar = camera.GetComponent<Dialog_Povar>();
        GameObject buttons = GameObject.FindWithTag("buttons");
        knopki = buttons.GetComponent<buttons_off>();
        TextObject = GameObject.FindWithTag("spesial");
        text1 = TextObject.GetComponent<TextMeshProUGUI>();
    }

    public void Update()
    {
        if (linkDialog_Povar.moment == 0)
        {
            StartCoroutine(Timer());
        }
    }

    public void net()
    {
        StartText.alpha = 0;
        NoText.alpha = 1;
        knopki.Press = true;
    }

    public void da()
    {
        StartText.alpha = 0;
        DaText.alpha = 1;
        knopki.Press = true;
    }

    public void button_menu()
    {
        if (Tarelki.TarelkiNow > 0)
        {
            text1.text = "я не буду готовить пока ты не разнесешь все готовое.";
            if (bluda == false)
            {
                Debug.Log("fakse");
                anim.SetBool("menu_vibar", true);
                StartText.alpha = 0;
                Menu_Text.alpha = 1;
                knopki.Press = true;
            }
            else if (bluda == true)
            {
                Debug.Log("true");
                StartText.alpha = 0;
                Menu_false_Text.alpha = 1;
                knopki.Press = true;
            }
        }
        else
        {
            text1.text = "Тарелок чистых нет, в чём мне готовить, дебил.";
            StartText.alpha = 0;
            Menu_false_Text.alpha = 1;
            knopki.Press = true;
        }
    }   

    private IEnumerator Timer()
    {
        yield return new WaitForSeconds(1f);
        StartText.alpha = 1;
        NoText.alpha = 0;
        DaText.alpha = 0;
        Menu_Text.alpha = 0;
        Menu_false_Text.alpha = 0;
        knopki.Press = false;
    }

    public void ok()
    {
        linkDialog_Povar.moment = 2;
    }
}