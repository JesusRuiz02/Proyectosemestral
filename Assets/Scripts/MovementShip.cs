using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovementShip : MonoBehaviour
{
    // Start is called before the first frame update

    private Rigidbody2D _rb;
    private float _dirX;
    private const float  MoveSpeed= 20f;
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        _dirX = Input.acceleration.x * MoveSpeed;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
    }

    private void FixedUpdate() 
    {
        _rb.velocity = new Vector2(_dirX, 0f);
    }

    public class PlayerCollision : MonoBehaviour
    {
        private int life = 3;
        private void OnTriggerEnter2D(Collider2D collision)
        {
           ProcessCollision(collision.gameObject);
        }
        private void OnCollisionEnter2D(Collision2D collision)
        {
            ProcessCollision(collision.gameObject);
        }
        private void ProcessCollision(GameObject collider)
        {
            if (collider.CompareTag("Obstacle"))
            {
                LostLife();
            }

            if (collider.CompareTag("Points"))
            {
                scorepoint();
            }
                
        }
        private void LostLife()
        {
            
            Debug.Log("Lost a life");
            life = life - 1;
            if (life<=0)
            {
                Debug.Log("Perdiste");
            }
        }

        private void scorepoint()
        {
            Debug.Log("You score a point");
        }
    }
    

   
}
