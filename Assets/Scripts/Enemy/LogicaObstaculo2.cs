using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LogicaObstaculo2 : MonoBehaviour
{
   
   
    public float velocidad = 4f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * velocidad * Time.deltaTime;
    }


    public void destroy()
    {
        Destroy(this.gameObject);
    }
}