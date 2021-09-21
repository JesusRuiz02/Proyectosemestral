using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerScene : MonoBehaviour
{
    private PlayerSettings playerSettings;
    public AudioSource audioSource;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);

    }

    public void volumeon()
    {
        playerSettings.IsmusicActive = true;
        playerSettings.IsFxActive = true;
    }

    public void volumeoff()
    {
        playerSettings.IsmusicActive = false;
        playerSettings.IsFxActive = false;
    }

    private void Start()
    {
        playerSettings = new PlayerSettings();
       
    }

    private void Update()
    {
        if (playerSettings.IsmusicActive==false)
        {
            audioSource.volume=0;
        }
        else
        {
            audioSource.volume = 1;
        }
        
        
    }
}