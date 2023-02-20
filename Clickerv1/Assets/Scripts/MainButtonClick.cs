using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//clica y genera una galleta
public class MainButtonClick : MonoBehaviour
{

    public GameObject textbox;
    public static int ClicBake = 1;

    public void ClickTheButtonBake() {

        
        GlobalCookies.CookieCount += ClicBake;
        GlobalCookies.InfiniteCookie += 1;
    }
    public void ClickTheButtonSell() {
        if (GlobalCookies.CookieCount == 0)
        {
           
        }
        else
        {
            GlobalCookies.CookieCount -= 1;
            GlobalCash.CashCount += 1;
        }
    }
}
