using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    public float Maxtime = 1f;
    public float initialtime = 0f;
    public GameObject Obstacle;
    public float range;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (initialtime>Maxtime)
        {
            GameObject NewObstacle = Instantiate(Obstacle);
            NewObstacle.transform.position = transform.position + new Vector3(Random.Range(-range, range), 0);
            Destroy(gameObject,40);
            initialtime = 0;

        }
        else
        {
            initialtime += Time.deltaTime;
        }




    }
}
