using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SellCookie : MonoBehaviour
{
    //dispara la animaci�n cuando no tienes mas galletas
    public GameObject textbox;
    public GameObject statusBox;

    public void ClickTheButton() {
        if (GlobalCookies.CookieCount == 0)
        {
            statusBox.GetComponent<Text>().text = "Not enought cookies to sell.";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else { 
            //resta una galleta, suma un or.

        GlobalCookies.CookieCount -= 1;
        GlobalCash.CashCount += 1;
        }

    }
}
