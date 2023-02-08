using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalMercader : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentMerc;
    public static int mercvalue = 50;
    public static bool TurnOffButton = false;
    public GameObject mercStats;
    public static int numberofMercs;
    public static int MercPerSec;


  // No es pot clicar comprar cuiner si no hi han 50 monedes.
    void Update()
    {
        currentMerc = GlobalCash.CashCount;
        mercStats.GetComponent<Text>().text = "Mercaders: " + numberofMercs;
        fakeText.GetComponent<Text>().text = "Mercader " + mercvalue + " Ors";
        realText.GetComponent<Text>().text = "Mercader " + mercvalue + " Ors";
        if (currentMerc >= mercvalue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (TurnOffButton == true) {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            TurnOffButton = false;
        }
        if (mercvalue > GlobalCash.CashCount)
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
    }
}
