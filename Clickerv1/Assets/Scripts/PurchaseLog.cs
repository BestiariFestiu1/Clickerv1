using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{ 
    //ACtivar autocrear cookies
    public GameObject AutoCookie;
    public GameObject AutoSell;
    public GameObject AutoDiable;
    public GameObject AutoGegant;
    public GameObject AutoMercader;
    public GameObject AutoOrfebre;

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

    public void StartAutoGegant()
    {
        AutoGegant.SetActive(true);
        // cuan es fa servir el global sell, augmenta el valor per 2
        GlobalCash.CashCount -= GlobalGegants.Gegantvalue;
        GlobalGegants.Gegantvalue *= 2;
        GlobalGegants.TurnOffButton = true;
        //Millora els sellers
        GlobalGegants.GegantsPerSec += 10;
        GlobalGegants.numberofGegants += 1;
    }

    public void StartAutoMercader()
    {
        AutoMercader.SetActive(true);
        // cuan es fa servir el global sell, augmenta el valor per 2
        GlobalCash.CashCount -= GlobalShop.shopvalue;
        GlobalMercader.mercvalue *= 2;
        GlobalMercader.TurnOffButton = true;
        //Millora els sellers
        GlobalMercader.MercPerSec += 5;
        GlobalMercader.numberofMercs += 1;
    }

    public void StartAutoOrfebre()
    {
        AutoOrfebre.SetActive(true);
        // cuan es fa servir el global sell, augmenta el valor per 2
        GlobalCash.CashCount -= GlobalShop.shopvalue;
        GlobalOrfebre.orfebrervalue *= 2;
        GlobalOrfebre.TurnOffButton = true;
        //Millora els sellers
        GlobalOrfebre.OrfebrePerSec += 10;
        GlobalOrfebre.numberofOrfebres += 1;
    }

    public void StartAutoFuet()
    {
        // cuan es fa servir el global sell, augmenta el valor per 2
        ChargeBeast.waterCount -= Fuets.Fuetvalue;
        Fuets.Fuetvalue *= 2;
        Fuets.TurnOffButton = true;
        MainButtonClick.ClicBake += 1;
        Fuets.numberofFuets += 1;
    }
    public void StartAutoBanya()
    {
        // cuan es fa servir el global sell, augmenta el valor per 2
        ChargeBeast.waterCount -= BanyaVerda.Fuetvalue;
        BanyaVerda.Fuetvalue *= 2;

        GlobalBaker.bakePerSec *= 2;
        GlobalDiables.DiablesPerSec *= 2;
        GlobalGegants.GegantsPerSec *= 2;

        BanyaVerda.TurnOffButton = true;
        BanyaVerda.numberofFuets += 1;
    }

    public void StartAutoLlum()
    {
        // cuan es fa servir el global sell, augmenta el valor per 2
        ChargeBeast.waterCount -= Llucifer.Fuetvalue;
        Llucifer.Fuetvalue *= 2;

        GlobalShop.ShopPerSec *= 2;
        GlobalMercader.MercPerSec *= 2;
        GlobalGegants.GegantsPerSec *= 2;

        Llucifer.TurnOffButton = true;
        Llucifer.numberofFuets += 1;
    }
}