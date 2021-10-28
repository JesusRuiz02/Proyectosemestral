using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSettings : MonoBehaviour
{
    // Start is called before the first frame update
    private PlayerCollision playerCollision;

    public AudioManager audioManager;

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
   public void Volumeon()
    {
        audioManager.SetMusicVolume(1);
    }
   public void Volumeoff()
    {
        audioManager.SetMusicVolume(0);
    }
   
  public  void Sfxon()
    {
        audioManager.SetSfxVolume(1);
    }
   
   public void Sfxoff()
    {
        audioManager.SetSfxVolume(0);
    }

}

