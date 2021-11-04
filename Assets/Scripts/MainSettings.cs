using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.VersionControl;
using UnityEngine;

public class MainSettings : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerCollision playerCollision;

    public AudioManager audioManager;
    private bool soundtoggle = true;
    private bool soundtoggle2 = true;
    public int volume;
    public int sfx;

    // Start is called before the first frame update
    void Start()
    {
        audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
       
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
   public void Volume()
   {
       soundtoggle = !soundtoggle;
       if (soundtoggle == true)
       {
           audioManager.SetMusicVolume(1);
           Debug.Log("Volume On");
           volume = 1;

       }
       else
       {
           audioManager.SetMusicVolume(0); 
           Debug.Log("Volume Off");
           volume = 0;
       }
      
    }
   
  public  void Sfxon()
    {
        soundtoggle2 = !soundtoggle2;
        if (soundtoggle2 == true)
        {
            audioManager.SetSfxVolume(1);
            Debug.Log("SfxOn");
            sfx = 1;
        }
        else
        {
            audioManager.SetSfxVolume(0);
            Debug.Log("sfxOff");
            sfx = 0;
        }
       
      
    }
   
   
}

