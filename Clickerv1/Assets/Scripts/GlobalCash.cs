using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalCash : MonoBehaviour
{
    //cuenta los oros.

    public static int CashCount;
    public GameObject CashDisplay;
    public int InternalCash; 

    void Update (){
        InternalCash = CashCount;
        CashDisplay.GetComponent<Text>().text = "Ors Acomulats: " + InternalCash;

    }
}
