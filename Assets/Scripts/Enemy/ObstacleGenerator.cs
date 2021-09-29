using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject Obstacle;
    public float speedspawn = 3f;
    public GameObject Enemy2;

    
    void Start()
    {
        RepeatEnemyBasic();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        



    }

    

   public void CreateEnemy()
    {
        Instantiate(Obstacle, transform.position, Quaternion.identity);
    }

   public void CreateEnemy2()
    {
        Instantiate(Enemy2, transform.position, Quaternion.identity);
    }

   public void RepeatEnemyBasic()
    {
        InvokeRepeating("CreateEnemy",0f,speedspawn);
    }

   public void RepeatEnemy2()
    {
        InvokeRepeating("CreateEnemy2", 0f,speedspawn);
    }

    public void StopSpawn()
    {
        CancelInvoke("CreateEnemy");
    }

     public void GetDifficult()
    {
        speedspawn = speedspawn - 0.3f;
    }
}

