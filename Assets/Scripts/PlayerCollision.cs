 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerCollision : MonoBehaviour
{
    public int life=3;
    public GameObject gameOverText;
    public GameObject bottonReset;
    
    public int score = 0;
    public Text scoreText;


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
            scorepoint();
            score++;
            scoreText.text = "Score: " + score;
        }
                
    }
    private void LostLife()
    {
            
        Debug.Log("Lost a life");
        life --;
        Debug.Log(life);
        if (life==0)
        {
            Debug.Log("Perdiste");
            gameOverText.SetActive(true);
            bottonReset.SetActive(true);
            Time.timeScale = 0;     
        }
    }

    private void scorepoint()
    {
        Debug.Log("You score a point");

        score++;
        scoreText.text = "Score: " + score;

    }
}
    

   

