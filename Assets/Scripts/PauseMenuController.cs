using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public GameObject pauseButton;
    public GameObject pauseText;
    public GameObject resumeButton;
    public GameObject settingsButton;
    public GameObject panel;
    public GameObject audioOn;
    public GameObject audioOff;
    public GameObject flecha;
    public GameObject menuButton;


    public void Update()
    {
        Debug.Log(Time.timeScale);
    }
    public void PausaGeneral()
    {
        Time.timeScale = 0f;
        pauseButton.SetActive(false);
        menuButton.SetActive(true);
        pauseText.SetActive(true);
        resumeButton.SetActive(true);
        settingsButton.SetActive(true);
        panel.SetActive(true);
    }

    public void ResumeGeneral()
    {
        Time.timeScale = 1;
        pauseButton.SetActive(true);
        menuButton.SetActive(false);
        pauseText.SetActive(false);
        resumeButton.SetActive(false);
        settingsButton.SetActive(false);
        audioOn.SetActive(false);
        audioOff.SetActive(false);
        panel.SetActive(false);
    }

    public void SettingsGameScene()
    {
        resumeButton.SetActive(false);
        menuButton.SetActive(false);
        flecha.SetActive(true);
        settingsButton.SetActive(false);
        audioOn.SetActive(true);
        audioOff.SetActive(true);
    }

    public void Flecharegreso()
    {
        flecha.SetActive(false);
        audioOn.SetActive(false);
        audioOff.SetActive(false);
        resumeButton.SetActive(true);
        settingsButton.SetActive(true);
        menuButton.SetActive(true);
    }
}   
