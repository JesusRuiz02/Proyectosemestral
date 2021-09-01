using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    private Rigidbody2D rb2d;
    public float scrollspeed = -1.5f;

    private void Awake()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        rb2d.velocity = new Vector2(0, scrollspeed);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}
