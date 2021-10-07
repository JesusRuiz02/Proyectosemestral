using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause1 : MonoBehaviour
{
    //public static bool GameIsPaused = false;
    public bool MainCanvas;
   

    // Update is called once per frame
    void Update()
    {
        if (MainCanvas==true)
        {

            Pause();
        }
        
       
    }

    
    void Pause ()
    {
        Time.timeScale = 0f;
    }
    

   
}
