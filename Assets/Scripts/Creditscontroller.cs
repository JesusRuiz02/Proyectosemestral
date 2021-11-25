using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Creditscontroller : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject creditsON;
    public GameObject returnb;

    public void nreditsON()
    {
        creditsON.SetActive(true);
        returnb.SetActive(false);
    }

    public void returnn()
    {
        creditsON.SetActive(false);
        returnb.SetActive(true);
    }
}
