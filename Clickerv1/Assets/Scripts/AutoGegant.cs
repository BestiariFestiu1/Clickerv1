using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoGegant: MonoBehaviour
{

    public bool CreatingCookie = false;
    public static int CookiesIncrease = 10;
    public int GiganticalIncrease;

    //Observar el valor de creacio de cookies, conecta amb "purchase Log"
    void Update ()
    {
        CookiesIncrease = GlobalGegants.GegantsPerSec; //Afegit, fa que els diables augmentin el treball.
        GiganticalIncrease = CookiesIncrease;
        if (CreatingCookie == false) 
        {
            CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }
    }

    // Cuan activar generar 1 cookie per segon
    IEnumerator CreateTheCookie()
    {
        GlobalCookies.CookieCount += GiganticalIncrease;
        GlobalCookies.InfiniteCookie += GiganticalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCookie = false;
    }
}
