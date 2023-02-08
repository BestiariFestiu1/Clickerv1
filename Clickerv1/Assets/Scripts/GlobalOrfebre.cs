using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalOrfebre : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentOrfebre;
    public static int orfebrervalue = 150;
    public static bool TurnOffButton = false;
    public GameObject orfebreStats;
    public static int numberofOrfebres;
    public static int OrfebrePerSec;


  // No es pot clicar comprar cuiner si no hi han 50 monedes.
    void Update()
    {
        currentOrfebre = GlobalCash.CashCount;
        orfebreStats.GetComponent<Text>().text = "Orfebres: " + numberofOrfebres;
        fakeText.GetComponent<Text>().text = "Orfebre " + orfebrervalue + " Ors";
        realText.GetComponent<Text>().text = "Orfebre " + orfebrervalue + " Ors";
        if (currentOrfebre >= orfebrervalue) {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (TurnOffButton == true) {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            TurnOffButton = false;
        }
        if (orfebrervalue > GlobalCash.CashCount)
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
    }
}
