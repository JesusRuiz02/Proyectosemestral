using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MovementShip : MonoBehaviour
{
    // Start is called before the first frame update
    public float horizontalinput;
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
        horizontalinput = Input.GetAxis("Horizontal");
        _dirX = Input.acceleration.x * MoveSpeed;
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.5f, 7.5f), transform.position.y);
        this.transform.Translate(MoveSpeed*Time.deltaTime*Vector3.right*horizontalinput);
    }

    private void FixedUpdate() 
    {
        _rb.velocity = new Vector2(_dirX, 0f);
    }
    
    }

  