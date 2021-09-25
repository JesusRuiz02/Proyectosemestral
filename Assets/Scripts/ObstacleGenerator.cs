using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject Obstacle;
    public float speedspawn = 3f;

    
    void Start()
    {
        RepeatEnemyBasic();
    }

    // Update is called once per frame
    void Update()
    {
        
        
        



    }

    

    void CreateEnemy()
    {
        Instantiate(Obstacle, transform.position, Quaternion.identity);
    }

    void RepeatEnemyBasic()
    {
        InvokeRepeating("CreateEnemy",0f,speedspawn);
    }

    void StopSpawn()
    {
        CancelInvoke("CreateEnemy");
    }

     public void GetDifficult()
    {
        speedspawn = speedspawn - 0.3f;
    }
}

