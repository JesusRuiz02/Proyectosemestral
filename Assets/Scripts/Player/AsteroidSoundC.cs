using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSoundC : MonoBehaviour
{
    public AudioSource CrashSound;
    
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Collider2D>();
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        CrashSound = GetComponent<AudioSource>();
        CrashSound.Play();
    }


    // Update is called once per frame
    void Update()
    {
               
    }
}
