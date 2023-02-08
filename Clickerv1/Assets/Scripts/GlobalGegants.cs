using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalGegants : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentGegant;
    public static int Gegantvalue = 150;
    public static bool TurnOffButton = false;
    public GameObject GegantStats;
    public static int numberofGegants;
    public static int GegantsPerSec;


  // No es pot clicar comprar cuiner si no hi han 50 monedes.
    void Update()
    {
       currentGegant = GlobalCash.CashCount;
        GegantStats.GetComponent<Text>().text = "Gegants: " + numberofGegants;
        fakeText.GetComponent<Text>().text = "Gegant " + Gegantvalue + " Ors";
        realText.GetComponent<Text>().text = "Gegant " + Gegantvalue + " Ors";
        if (currentGegant >= Gegantvalue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (TurnOffButton == true) {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            TurnOffButton = false;
        }
        if (Gegantvalue > GlobalCash.CashCount)
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
    }
}
