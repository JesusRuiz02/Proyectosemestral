 using System;
 using System.Collections;
using System.Collections.Generic;
 using System.Security.Cryptography.X509Certificates;
 using UnityEngine;
using UnityEngine.UI;
 using Object = UnityEngine.Object;
using TMPro;

 public class PlayerCollision : MonoBehaviour
 {

     public Animator ac;
    public int life=3, Limitscore=10;
    public Slider Healthslider;
    public GameObject gameOverText;
    public GameObject bottonReset;
    public GameObject bottonMenu;
    public GameObject botonPause;
    public float score = 0;
    public Text scoreText;
    public ObstacleGenerator obstaclegenerator;
    public ObstacleGenerator ObstacleGenerator2;
    public ObstacleGenerator ObstacleGenerator3;
    public ObstacleGenerator1 ObstacleGenerator4;
    public ObstacleGenerator1 ObstacleGenerator5;
    public AudioSource NaveSound;
    public GameObject Nave;
    public TextMeshProUGUI HighscoreText;
    private AudioManager audioManager;
    public GameObject life1, life2, life3;
    

    void Start()
    {
       HighscoreText.text = PlayerPrefs.GetFloat("Text-highscore", 0).ToString();
       audioManager = GameObject.FindGameObjectWithTag("AudioManager").GetComponent<AudioManager>();
       life1.gameObject.SetActive(true);
       life2.gameObject.SetActive(true);
       life3.gameObject.SetActive(true);
    }
    private void Update()
    {
       scoretimer();
       //Debug.Log(score);
       if (life==3)
       {
           life1.gameObject.SetActive(true);
           life2.gameObject.SetActive(true);
           life3.gameObject.SetActive(true);
       }
       else if (life==2)
       {
           life1.gameObject.SetActive(true);
           life2.gameObject.SetActive(true);
           life3.gameObject.SetActive(false);
       }
       else if (life==1)
       {
           life1.gameObject.SetActive(true);
           life2.gameObject.SetActive(false);
           life3.gameObject.SetActive(false);
       }
       else if (life==0)
       {
           life1.gameObject.SetActive(false);
           life2.gameObject.SetActive(false);
           life3.gameObject.SetActive(false);
       }
       
       
       

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
            Healthslider.value -= life;
            collider.GetComponent<LogicaObstaculo2>();
            LogicaObstaculo2 obstaculo = collider.GetComponent<LogicaObstaculo2>();
            obstaculo.destroy();
           explosion();
            
        }
        if (collider.CompareTag("Obstacle2"))
        {
            LostLife();
            Healthslider.value -= life;
            collider.GetComponent<ObstacleLogicZigzag2>();
            ObstacleLogicZigzag2 obstaculo = collider.GetComponent<ObstacleLogicZigzag2>();
            obstaculo.destroy();
            explosion();
            
        }
        if (collider.CompareTag("Obstacle3"))
        {
            LostLife();
            Healthslider.value -= life;
            collider.GetComponent<Obstacle3>();
            Obstacle3 obstaculo = collider.GetComponent<Obstacle3>();
            obstaculo.destroy();
            explosion();
            
        }
        if (collider.CompareTag("Obstacle4"))
        {
            LostLife();
            Healthslider.value -= life;
            collider.GetComponent<Obstacle4>();
            Obstacle4 obstaculo = collider.GetComponent<Obstacle4>();
            obstaculo.destroy();
            explosion();
            
        }
        
        

        if (collider.CompareTag("Points"))
        {
            scorepointbonus();
            score=score+10;
            scoreText.text = "Score: " + score;
            collider.GetComponent<LogicaObstaculo3>();
            LogicaObstaculo3 punto = collider.GetComponent<LogicaObstaculo3>();
            punto.destroy();
        }

        

        
    }

    
    

    
    private void LostLife()
    {
            
        Debug.Log("Lost a life");
        
        life--;
        if (life==0)
        {
            Healthslider.value = 0;
            ac.SetBool("DED", true);
            Debug.Log("Perdiste");
            gameOverText.SetActive(true);   
            bottonReset.SetActive(true);
            bottonMenu.SetActive(true);
            botonPause.SetActive(false);
            Destroy(Nave, 1f);
            Destroy(ObstacleGenerator2);
            Destroy(ObstacleGenerator3);
            Destroy(ObstacleGenerator4);
            Destroy(ObstacleGenerator5);
            Destroy(obstaclegenerator);
            

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
       // if (score >= Limitscore)
       // {
         //   if (obstaclegenerator.speedspawn >= 0.5)
         //   {
             //   obstaclegenerator.GetDifficult();
              //  ObstacleGenerator2.GetDifficult();
             //   ObstacleGenerator3.GetDifficult();
          //  }

          //  Limitscore = Limitscore + 10;
          
     //   }
     if (score>PlayerPrefs.GetFloat("Text-Highscore",0))
     {
         PlayerPrefs.SetFloat("Text-highscore",score);  
         HighscoreText.text = "Highscore: "+ score.ToString();
     }


       

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
    

    

}
    

   

