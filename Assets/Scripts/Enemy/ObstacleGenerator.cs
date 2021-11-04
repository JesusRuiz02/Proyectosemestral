using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ObstacleGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject Obstacle;
    public float speedspawn =3f;
    public GameObject Enemy2;
    public float limit = 3;
    public  float score=0;
    public float timer = 0;
   

    
    void Start()
    { 
        //RepeatEnemyBasic();
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        //score += Time.deltaTime;
        GetDifficult();

     
        

    }

    

   public void CreateEnemy()
    {
       // Debug.Log("Se creo");
        Instantiate(Obstacle, transform.position, Quaternion.identity);
        
    }

   //public void CreateEnemy2()
   // {
     //   Instantiate(Enemy2, transform.position, Quaternion.identity);
   //}

   public void RepeatEnemyBasic()
    {
        InvokeRepeating("CreateEnemy",0f,speedspawn);
        
    }

 //  public void RepeatEnemy2()
  //  {
   //     InvokeRepeating("CreateEnemy2", 0f,speedspawn);
   // }

    public void StopSpawn()
    {
        CancelInvoke("CreateEnemy");
    }

     public void GetDifficult()
    {
        if (speedspawn>=1.5)
        {
            if (timer>=speedspawn)
            {
                CreateEnemy();
                timer = 0;
                speedspawn = speedspawn - 0.1f;
            }
 
        }
        else
        {
            speedspawn = 1.6f;
            CreateEnemy();
        }
        
    }

   

    public void dead()
    {
       
        Time.timeScale = 0;
    }
    
}

