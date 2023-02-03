using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{ 
    //ACtivar autocrear cookies
    public GameObject AutoCookie;
    public GameObject AutoSell;
    public GameObject AutoDiable;

    public void StartAutoCookie()
    {
        AutoCookie.SetActive(true);
        // cuan es fa servir el global baker, augmenta el valor per 2
        GlobalCash.CashCount -= GlobalBaker.bakervalue;
        GlobalBaker.bakervalue *= 2;
        GlobalBaker.TurnOffButton = true;
        //Millora els bakers
        GlobalBaker.bakePerSec += 1;
        GlobalBaker.numberofBakers += 1;
    }

    public void StartAutoSell()
    {
        AutoSell.SetActive(true);
        // cuan es fa servir el global sell, augmenta el valor per 2
        GlobalCash.CashCount -= GlobalShop.shopvalue;
        GlobalShop.shopvalue *= 2;
        GlobalShop.TurnOffButton = true;
        //Millora els sellers
        GlobalShop.ShopPerSec += 1;
        GlobalShop.numberofShops += 1;
    }

    public void StartAutoDiable()
    {
        AutoDiable.SetActive(true);
        // cuan es fa servir el global sell, augmenta el valor per 2
        GlobalCash.CashCount -= GlobalDiables.Diablevalue;
        GlobalDiables.Diablevalue *= 2;
        GlobalDiables.TurnOffButton = true;
        //Millora els sellers
        GlobalDiables.DiablesPerSec += 5;
        GlobalDiables.numberofDiables += 1;
    }
}