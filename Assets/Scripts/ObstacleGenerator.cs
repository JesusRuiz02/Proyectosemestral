using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    // Start is called before the first frame update

    private float Maxtime = 2f;
    public float initialtime = 0f;
    public GameObject Obstacle;
    public float range;
    public GameObject score;
    //public int Score=0;
    
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

    public void SpeedSpawn()
    {
        Debug.Log("más rápido");

        if (Maxtime > 0)
        {
            Maxtime = Maxtime - 1;
        }
        else
        {
            Maxtime = 1;
        }

        Maxtime = Maxtime--;
        
    }
}

