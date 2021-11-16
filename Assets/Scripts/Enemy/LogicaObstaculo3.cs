using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class LogicaObstaculo3 : MonoBehaviour
{
    MissileSpawner missileSpawner;

    public float score = 3;
    public float velocidad = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        transform.position += Vector3.down * velocidad * Time.deltaTime;
        if (score>10)
        {
            velocidad = velocidad + 0.1f;
            score = 0;
        }
        if (transform.position.y<=-15)
        {
            destroy();  
        }
    }

  

    public void destroy()
    {
        Destroy(this.gameObject);
    }
}
