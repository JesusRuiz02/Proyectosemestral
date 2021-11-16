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
        transform.Translate(-1*Time.deltaTime*3,-1*Time.deltaTime*2,0);
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
