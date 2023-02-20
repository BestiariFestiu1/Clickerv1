using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChargeBeast : MonoBehaviour
{
    int vidaBestia = 10;
    public int VidaBestiaActual;
    public static int waterCount = 0;
    public GameObject waterDisplay;
    public int Internalwater;
    public bool Startnumerator = false;
    List<GameObject> prefabList = new List<GameObject>();
    public GameObject Bestia1;
    public GameObject Bestia2;
    public GameObject Bestia3;
    public GameObject Bestia4;
    public GameObject Bestia5;
    public int comparador;
    int prefabIndex;
    GameObject Invocacion;
    GameObject Destruye;

    // Start is called before the first frame update
    void Start()
    {

        prefabList.Add(Bestia1);
        prefabList.Add(Bestia2);
        prefabList.Add(Bestia3);
        prefabList.Add(Bestia4);
        prefabList.Add(Bestia5);
        StartCoroutine(NovaBestia());

 
    }

    // Update is called once per frame
    void Update()
    {

        Internalwater = waterCount;
        waterDisplay.GetComponent<Text>().text = "Aigua Acomulada: " + Internalwater;
        comparador = GlobalCookies.InfiniteCookie;
        if (comparador >= VidaBestiaActual)
        {
            waterCount += 1;
            Startnumerator = false;
            StartCoroutine(NovaBestia());
        }
        else
        {
         
        }

    }

    IEnumerator NovaBestia() {

        if (Startnumerator == false) {
            
            vidaBestia *= 2;
        VidaBestiaActual = vidaBestia;

           GameObject destruye = GameObject.Find("Invocado");
            Destroy(destruye);

        int prefabIndex = UnityEngine.Random.Range(0, 5);
        Invocacion = Instantiate(prefabList[prefabIndex]);
            Invocacion.name = "Invocado";
            Invocacion.GetComponent<Canvas>().enabled = true;
            Startnumerator = true;
        }
        return null;
    }



}
