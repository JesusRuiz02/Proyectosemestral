using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(-2*Time.deltaTime,-1*Time.deltaTime*4,0);
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
