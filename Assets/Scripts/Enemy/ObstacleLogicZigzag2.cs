using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleLogicZigzag2 : MonoBehaviour
{
    public float score = 0;
    public float velocidad = 2f;
    public float frequency =2.0f; // Speed of sine movement
    public float magnitude = 2.0f; //  Size of sine movement, its the amplitude of the side curve
   

    Vector3 pos;
    Vector3 axis;

    // Start is called before the first frame update
    void Start()
    {
        // intialization for zigzag parameters
        pos = transform.position;
        axis = transform.right;
    }
    public float change = 2;
 
    

    // Update is called once per frame
    void Update()
    {
        score += Time.deltaTime;
        change += Time.deltaTime;
        if (score>10)
        {
            if (velocidad<4)
            {
                velocidad = velocidad + 0.1f;
                score = 0;
            }
            else
            {
                velocidad = 3.9f;
            }
        
        }
        pos += Vector3.down * Time.deltaTime * velocidad;
        transform.position = pos + axis * Mathf.Sin(Time.time * frequency) * magnitude; // y = A sin(B(x)) , here A is Amplitude, and axis * magnitude is acting as amplitude. Amplitude means the depth of the sin curve

       // if (change>0.1)
      // {
         // right();
         
       // }
      //  else
      //  {
      //      
     //   }
        
       
        

        if (transform.position.y<=-40)
        {
          destroy();  
        }
    }


    public void destroy()
    {
        Destroy(this.gameObject);
    }

    public void left()
    {
       transform.Translate(-1*Time.deltaTime,-1*Time.deltaTime*velocidad,0); 
    }

    public void right()
    {
        transform.Translate(1*Time.deltaTime,-1*Time.deltaTime*velocidad,0); 
    }
}

