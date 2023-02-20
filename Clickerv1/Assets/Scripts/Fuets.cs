using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fuets : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realButton;
    public GameObject realText;
    public int currentFuet;
    public static int Fuetvalue = 1;
    public static bool TurnOffButton = false;
    public GameObject FuetStats;
    public static int numberofFuets;


    // No es pot clicar comprar cuiner si no hi han 50 monedes.
    void Update()
    {
        currentFuet = ChargeBeast.waterCount;
        FuetStats.GetComponent<Text>().text = "Fuets: " + numberofFuets;
        fakeText.GetComponent<Text>().text = "Fuets " + Fuetvalue + " Aigua";
        realText.GetComponent<Text>().text = "Fuets " + Fuetvalue + " Aigua";
        if (currentFuet >= Fuetvalue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (TurnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            TurnOffButton = false;
        }
        if (Fuetvalue > ChargeBeast.waterCount)
        {
            fakeButton.SetActive(true);
            realButton.SetActive(false);
        }
    }

}
