using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalShop : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int shopvalue = 10;
    public static bool TurnOffButton = false;
    public GameObject shopStats;
    public static int numberofShops;
    public static int ShopPerSec;


  // No es pot clicar comprar cuiner si no hi han 50 monedes.
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        shopStats.GetComponent<Text>().text = "Shopers: " + numberofShops;
        fakeText.GetComponent<Text>().text = "Buy Baker " + shopvalue;
        realText.GetComponent<Text>().text = "Buy Baker " + shopvalue;
        if (currentCash >= shopvalue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (TurnOffButton == true) {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            TurnOffButton = false;
        }
    }
}
