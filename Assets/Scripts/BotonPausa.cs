using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotonPausa : MonoBehaviour
{
    private bool active;
    public GameObject panel;
    public GameObject returnGame;
    public GameObject botonPausa;
    public GameObject pauseText;
    public GameObject VolumenOn;
    public GameObject VolumenOff;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void pausaActiva()
    {
        Time.timeScale = 0;
        panel.SetActive(true);
        returnGame.SetActive(true);
        pauseText.SetActive(true);
        VolumenOn.SetActive(true);
        VolumenOff.SetActive(true);
        botonPausa.SetActive(false);
    }

    public void botonRegresar()
    {
        Time.timeScale = 1;
        panel.SetActive(false);
        returnGame.SetActive(false);
        pauseText.SetActive(false);
        VolumenOn.SetActive(false);
        VolumenOff.SetActive(false);
        botonPausa.SetActive(true);
    }
}
