using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoCookie: MonoBehaviour
{

    public bool CreatingCookie = false;
    public static int CookieIncrease = 1;
    public int InternalIncrease;

    //Observar el valor de creacio de cookies, conecta amb "purchase Log"
    void Update ()
    {
        CookieIncrease = GlobalBaker.bakePerSec; //Afegit, fa que els bakers augmentin el treball.
        InternalIncrease = CookieIncrease;
        if (CreatingCookie == false) 
        {
            CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }
    }

    // Cuan activar generar 1 cookie per segon
    IEnumerator CreateTheCookie()
    {
        GlobalCookies.CookieCount += InternalIncrease;
        GlobalCookies.InfiniteCookie += InternalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCookie = false;
    }
}
