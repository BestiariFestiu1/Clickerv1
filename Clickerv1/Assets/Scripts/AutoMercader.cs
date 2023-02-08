using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoMercader : MonoBehaviour
{

    public bool SellingCookie = false;
    public static int CashIncrease = 1;
    public int MercalicalIncrease;

    //Observar el valor de creacio de cookies, conecta amb "purchase Log"
    void Update ()
    {
       CashIncrease = GlobalMercader.MercPerSec; //Afegit, fa que els bakers augmentin el treball.
        MercalicalIncrease = CashIncrease;
        if (SellingCookie == false) 
        {
            SellingCookie = true;
            StartCoroutine(SellTheCookie());
        }
    }

    // Cuan activar generar 1 cookie per segon
    IEnumerator SellTheCookie()
    {
        if (GlobalCookies.CookieCount <= 0)
        {
            GlobalCookies.CookieCount = 0;
            yield return new WaitForSeconds(10);
            StartCoroutine(SellTheCookie());
        }
        else
        {
            GlobalCash.CashCount += MercalicalIncrease;

            GlobalCookies.CookieCount -= MercalicalIncrease;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }

   
    }
}
