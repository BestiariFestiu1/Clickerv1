using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalBaker : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentCash;
    public static int bakervalue = 10;
    public static bool TurnOffButton = false;
    public GameObject bakerStats;
    public static int numberofBakers;
    public static int bakePerSec;


  // No es pot clicar comprar cuiner si no hi han 50 monedes.
    void Update()
    {
        currentCash = GlobalCash.CashCount;
        bakerStats.GetComponent<Text>().text = "Bakers: " + numberofBakers;
        fakeText.GetComponent<Text>().text = "Buy Baker " + bakervalue;
        realText.GetComponent<Text>().text = "Buy Baker " + bakervalue;
        if (currentCash >= bakervalue) {
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
