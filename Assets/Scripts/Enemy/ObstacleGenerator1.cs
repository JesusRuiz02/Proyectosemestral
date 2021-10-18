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

    public float timer = 0;

    // Start is called before the first frame update
    void Start()
    {

        // Start is called before the first frame update


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
            Debug.Log("Se creo");
            Instantiate(Obstacle, transform.position, Quaternion.identity);

        }

        //public void CreateEnemy2()
        // {
        //   Instantiate(Enemy2, transform.position, Quaternion.identity);
        //}

        public void RepeatEnemyBasic()
        {
            InvokeRepeating("CreateEnemy", 0f, speedspawn);

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
            if (speedspawn >= 2)
            {
                if (timer >= speedspawn)
                {
                    CreateEnemy();
                    timer = 0;
                    speedspawn = speedspawn - 0.1f;
                }

            }
            else
            {
                speedspawn = 1.1f;
                CreateEnemy();
            }

        }



        public void dead()
        {

            Time.timeScale = 0;
        }

    }


        

    

 
