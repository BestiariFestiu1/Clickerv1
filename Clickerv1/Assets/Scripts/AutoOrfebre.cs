using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoOrfebre : MonoBehaviour
{

    public bool SellingCookie = false;
    public static int CashIncrease = 1;
    public int OrfebrasticIncrease;

    //Observar el valor de creacio de cookies, conecta amb "purchase Log"
    void Update ()
    {
       CashIncrease = GlobalOrfebre.OrfebrePerSec; //Afegit, fa que els bakers augmentin el treball.
        OrfebrasticIncrease = CashIncrease;
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
            GlobalCash.CashCount += OrfebrasticIncrease;

            GlobalCookies.CookieCount -= OrfebrasticIncrease;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }

   
    }
}
