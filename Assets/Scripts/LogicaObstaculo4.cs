using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObstaculo4 : MonoBehaviour
{
    public float velocidad = 20f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.right * velocidad * Time.deltaTime;
    }
}

