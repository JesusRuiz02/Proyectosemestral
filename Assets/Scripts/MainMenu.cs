using System.Collections;
using System.Collections.Generic;using UnityEditor.VersionControl;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    private PlayerCollision playerCollision;
    [HideInInspector]
    public AudioManager audioManager;

    public GameObject audioManagerRef;
    // Start is called before the first frame update
    void Start()
    {
        var audioManagerInScene = GameObject.FindGameObjectWithTag("AudioManager");
        if (audioManagerInScene!=null)
        {
            audioManager = audioManagerInScene.GetComponent<AudioManager>();
        }
        else
        {
           
            audioManager = Instantiate(audioManagerRef).GetComponent<AudioManager>();
            audioManager.Iniatilize();
        }
        var mainMusic = audioManager.GetMusicAudioSourceBy("Time");
        if (mainMusic != null)
        {
            mainMusic.Play();
        }
        else
        {
            Debug.LogError("No encontre el audio");
        }
    }
    
    // Update is called once per frame
    void Update()
    {
        
       
    }

   public void explosion()
    {
        var explosion = audioManager.GetSfxAudioSourceBy("Meteor_Explosive_Mono_01");
        if (explosion != null)
        {
            explosion.Play();
        }
        else
        {
            Debug.LogError("No se encontro clip");
        }
    }
   
   
   void Volumeon()
   {
       audioManager.SetMusicVolume(1);
   }
   void Volumeoff()
   {
       audioManager.SetMusicVolume(0);
   }
   
   void Sfxon()
   {
       audioManager.SetSfxVolume(1);
   }
   
   void Sfxoff()
   {
       audioManager.SetSfxVolume(0);
   }
}


