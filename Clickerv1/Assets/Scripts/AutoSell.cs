using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoSell : MonoBehaviour
{

    public bool SellingCookie = false;
    public static int CashIncrease = 1;
    public int InternalIncrease;

    //Observar el valor de creacio de cookies, conecta amb "purchase Log"
    void Update ()
    {
       CashIncrease = GlobalShop.ShopPerSec; //Afegit, fa que els bakers augmentin el treball.
        InternalIncrease = CashIncrease;
        if (SellingCookie == false) 
        {
            SellingCookie = true;
            StartCoroutine(SellTheCookie());
        }
    }

    // Cuan activar generar 1 cookie per segon
    IEnumerator SellTheCookie()
    {
        if (GlobalCookies.CookieCount == 0)
        {
            yield return new WaitForSeconds(10);
            StartCoroutine(SellTheCookie());
        }
        else
        {
            GlobalCash.CashCount += InternalIncrease;
            GlobalCookies.CookieCount -= InternalIncrease;
            yield return new WaitForSeconds(1);
            SellingCookie = false;
        }
   
    }
}
