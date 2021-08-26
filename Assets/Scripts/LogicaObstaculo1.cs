using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaObstaculo1 : MonoBehaviour
{
    public float velocidad = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * velocidad * Time.deltaTime;
    }
}
