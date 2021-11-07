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
       // audioManager.SetMusicVolume(playerSettings.isMusic);
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
        var mainMusic = audioManager.GetMusicAudioSourceBy("Videjuego_1_");
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

   
   
   
  public void Volumeon()
   {
       audioManager.SetMusicVolume(1);
   }
   public void Volumeoff()
   {
       audioManager.SetMusicVolume(0);
   }
   
 public void Sfxon()
   {
       audioManager.SetSfxVolume(1);
   }
   
 public void Sfxoff()
   {
       audioManager.SetSfxVolume(0);
   }
}


