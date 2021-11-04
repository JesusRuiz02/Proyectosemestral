using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Analytics;

public class ControllerScene : MonoBehaviour
{
    private PlayerSettings playerSettings;
    public AudioSource audioSource;
    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        AnalyticsResult result = Analytics.CustomEvent("They start a game");
        Debug.Log("AnalyticsResult: " + result);
    }

   /* public void volumeon()
    {
        playerSettings.IsmusicActive = true;
        playerSettings.IsFxActive = true;
        LoadSaveManager.SavedPlayerSettings(playerSettings);
    }

    public void volumeoff()
    {
        playerSettings.IsmusicActive = false;
        playerSettings.IsFxActive = false;
        LoadSaveManager.SavedPlayerSettings(playerSettings);
    }

    private void Start()
    {
        playerSettings = new PlayerSettings();

        playerSettings = LoadSaveManager.LoadPlayerSettings();

    }

    void Update()
    {
        Debug.Log(playerSettings.IsmusicActive);
        if (playerSettings.IsmusicActive==false)
        {
            audioSource.volume=0;
        }
        else
        {
            audioSource.volume = 1;
        }
        
        
    }*/
}