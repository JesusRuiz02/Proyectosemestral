using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator1 : MonoBehaviour
{
    public GameObject Obstacle;
    public float speedspawn = 5f;
    public GameObject Enemy2;
    public float limit = 3;
    public float score = 0;
    public float speedspawn2 = 7;
    public float timer = 0;
    public float score2 = 0;

    // Start is called before the first frame update
    void Start()
    {
        RepeatEnemyBasic();
        RepeatEnemyZigzag();
        // Start is called before the first frame update
       

    }
    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
       
      
        
       
        //score += Time.deltaTime;
        // GetDifficult();
       // if (timer >= 10)
       // {
          //  score += Time.deltaTime;
         //   if (score>=speedspawn)
         //   {
          //     CreateEnemy();
          //     score = 0;
          //  }

           
     //   }

      //  if (timer >= 60)
      //  {
            
          //  score2 += Time.deltaTime;
         //   if (score2>speedspawn2)
           // {
         //       CreateEnemy2();
          //      score2 = 0;
           // }
           
       // }

        
    }



    public void CreateEnemy()
    {
        Debug.Log("Se creo");
        Instantiate(Obstacle, transform.position, Quaternion.identity);

    }

    public void CreateEnemy2()
    {
        Instantiate(Enemy2, transform.position, Quaternion.identity);
    }

    public void RepeatEnemyZigzag()
    {
        InvokeRepeating("CreateEnemy2", 60f, speedspawn2);
    }

    public void RepeatEnemyBasic()
    {
        InvokeRepeating("CreateEnemy", 30f, speedspawn);

    }

    public void stopspwanzizag()
    {
        CancelInvoke("CreateEnemy2");
    }

    public void StopSpawn()
    {
        CancelInvoke("CreateEnemy");
    }

  
    

    public void dead()
    {

        Time.timeScale = 0;
    }

}




    