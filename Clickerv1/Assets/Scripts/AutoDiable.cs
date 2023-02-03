using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoDiable: MonoBehaviour
{

    public bool CreatingCookie = false;
    public static int CookiesIncrease = 5;
    public int DiabolicalIncrease;

    //Observar el valor de creacio de cookies, conecta amb "purchase Log"
    void Update ()
    {
        CookiesIncrease = GlobalDiables.DiablesPerSec; //Afegit, fa que els diables augmentin el treball.
        DiabolicalIncrease = CookiesIncrease;
        if (CreatingCookie == false) 
        {
            CreatingCookie = true;
            StartCoroutine(CreateTheCookie());
        }
    }

    // Cuan activar generar 1 cookie per segon
    IEnumerator CreateTheCookie()
    {
        GlobalCookies.CookieCount += DiabolicalIncrease;
        yield return new WaitForSeconds(1);
        CreatingCookie = false;
    }
}
