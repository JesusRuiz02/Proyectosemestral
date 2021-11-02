using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementShoot : MonoBehaviour
{
    private MissileSpawner _missileSpawner;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up*Time.deltaTime*10);
        if (transform.position.y>=15)
        {
           destroy();
        }
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        ProcessCollision(collision.gameObject);
        
        
    }

    private void ProcessCollision(GameObject collider)
    {
        if (collider.CompareTag("Obstacle"))
        {


            collider.GetComponent<LogicaObstaculo2>();
            LogicaObstaculo2 obstaculo = collider.GetComponent<LogicaObstaculo2>();
            obstaculo.destroy();
            destroy();
            


        }
        if (collider.CompareTag("Obstacle2"))
        {


            collider.GetComponent<ObstacleLogicZigzag2>();
            ObstacleLogicZigzag2 obstaculo = collider.GetComponent<ObstacleLogicZigzag2>();
            obstaculo.destroy();
            destroy();
            


        }

    }
    
    

    public void destroy()
    {
        
        Destroy(this.gameObject);
    }
}
