 using System;
 using System.Collections;
using System.Collections.Generic;
 using System.Security.Cryptography.X509Certificates;
 using UnityEngine;
using UnityEngine.UI;
 using Object = UnityEngine.Object;

 public class PlayerCollision : MonoBehaviour
{
    
    
    public int life=3, Limitscore=10;
    public GameObject gameOverText;
    public GameObject bottonReset;
    public GameObject bottonMenu;
    public float score = 0;
    public Text scoreText;
    public ObstacleGenerator obstaclegenerator;
    public ObstacleGenerator ObstacleGenerator2;
    public ObstacleGenerator ObstacleGenerator3;

    void Start()
    {
       
       
    }
    private void Update()
    {
       scoretimer();
       //Debug.Log(score);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ProcessCollision(collision.gameObject);
    }
       
    private void ProcessCollision(GameObject collider)
    {
        if (collider.CompareTag("Obstacle"))
        {
            LostLife();
            collider.GetComponent<LogicaObstaculo2>();
            LogicaObstaculo2 obstaculo = collider.GetComponent<LogicaObstaculo2>();
            obstaculo.destroy();
        }
        
        if (collider.CompareTag("Points"))
        {
            scorepointbonus();
            score++;
            scoreText.text = "Score: " + score;
        }
                
    }
    private void LostLife()
    {
            
        Debug.Log("Lost a life");
        life--;
        if (life==0)
        {
            Debug.Log("Perdiste");
            gameOverText.SetActive(true);
            bottonReset.SetActive(true);
            bottonMenu.SetActive(true);
            Time.timeScale = 0;     
        }
    }

    private void scorepointbonus()
    {
        Debug.Log("You score a point");

        score++;
        scoreText.text = "Score: " + score;

    }


    private void scoretimer()
    {
        score += Time.deltaTime;
        scoreText.text = "Score: " + Math.Round(score, 0);
        if (score >= Limitscore)
        {
            if (obstaclegenerator.speedspawn >= 0.5)
            {
                obstaclegenerator.GetDifficult();
                ObstacleGenerator2.GetDifficult();
                ObstacleGenerator3.GetDifficult();
            }

            Limitscore = Limitscore + 10;
        }

       

    }

   
}
    

   

