using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalDiables : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentDiable;
    public static int Diablevalue = 50;
    public static bool TurnOffButton = false;
    public GameObject DiableStats;
    public static int numberofDiables;
    public static int DiablesPerSec;


  // No es pot clicar comprar cuiner si no hi han 50 monedes.
    void Update()
    {
        currentDiable = GlobalCash.CashCount;
        DiableStats.GetComponent<Text>().text = "Diables: " + numberofDiables;
        fakeText.GetComponent<Text>().text = "Diable " + Diablevalue + " Ors";
        realText.GetComponent<Text>().text = "Diable " + Diablevalue + " Ors";
        if (currentDiable >= Diablevalue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (TurnOffButton == true) {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            TurnOffButton = false;
        }
        if (Diablevalue > GlobalCash.CashCount)
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
    }
}
