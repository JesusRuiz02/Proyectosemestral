using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovementShip : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalinput;
    public float verticalinput;
    private Rigidbody2D _rb;
    private float _dirX,_dirY;
    private const float  MoveSpeed= 20f;

    public GameObject leftWall;
    public GameObject rigthWall;
    //public GameObject Naveee;

 
    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        horizontalinput = Input.GetAxis("Horizontal");
       // verticalinput = Input.GetAxis("Vertical");
        _dirX = Input.acceleration.x * MoveSpeed;
        //_dirY = Input.acceleration.y * MoveSpeed;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), Mathf.Clamp(transform.position.y, -3f, 3f));
        this.transform.Translate(MoveSpeed*Time.deltaTime*Vector3.right*horizontalinput);
        //this.transform.Translate(MoveSpeed*Time.deltaTime*Vector3.up*verticalinput);
       

        if(transform.position.x < leftWall.transform.position.x)
        {
            transform.position=new Vector3(leftWall.transform.position.x, transform.position.y, 0);
        }
        if(transform.position.x > rigthWall.transform.position.x)
        {
            transform.position = new Vector3(rigthWall.transform.position.x, transform.position.y, 0);
        }

       
            

    }

    private void FixedUpdate() 
    {
        _rb.velocity = new Vector2(_dirX, 0);
    }
    
    /*public void Dead()
    {
        Destroy(Naveee);
    }*/

   
}

  