using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using Random = UnityEngine.Random;

public class PointGenerator : MonoBehaviour
{
    public GameObject Point;

   
    // Start is called before the first frame update
    void Start()
    {
       repeatinvoke(); 
       repeatrandom();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void pointg()
    {
        Instantiate(Point, transform.position, quaternion.identity);
    }

    void repeatinvoke()
    {
        InvokeRepeating("pointg", 20, 15);
    }

    void random()
    {
        transform.Translate(Random.Range(3.0f,-3.0f),9,0);
    }

    void repeatrandom()
    {
        InvokeRepeating("random",0,3);
    }
    
    
}
