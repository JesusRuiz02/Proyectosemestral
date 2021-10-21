using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheSpawn : MonoBehaviour
{
    public GameObject ObstacleGenerator;
    public GameObject ObstacleGenerator2;
    public GameObject ObstacleGenerator3;
    public GameObject ObstacleGenerator4;
    public GameObject ObstacleGenerator5;
    public float Timer = 0;
    public float Timerlimit = 30;
    public int Order=0;
    
    // Start is called before the first frame update
    void Start()
    {
        Formation1();
    }

    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer>=7)
        {
            Formation2();
        }

        if (Timer>=14)
        {
            Formation3();
        }

        if (Timer>=21)
        {
            Formation4();
        }

        if (Timer>=28)
        {
            Random1();
        }
    }

    void Formation1()
    {
        ObstacleGenerator.transform.position=new Vector3(0,5,0);
        ObstacleGenerator2.transform.position=new Vector3(2,7,0); 
        ObstacleGenerator3.transform.position=new Vector3(-2,9,0);
        ObstacleGenerator4.transform.position= new Vector3(1, 6, 0);
        ObstacleGenerator5.transform.position = new Vector3(-1, 9, 0);
    }

    void Formation2()
    {
        ObstacleGenerator.transform.position = new Vector3(0, 7, 0);
        ObstacleGenerator2.transform.position = new Vector3(2, 9, 0);
        ObstacleGenerator3.transform.position = new Vector3(-2, 5, 0);
        ObstacleGenerator4.transform.position= new Vector3(1, 9, 0);
        ObstacleGenerator5.transform.position = new Vector3(-1, 6, 0);
    }

    void Formation3()
    {
        ObstacleGenerator.transform.position = new Vector3(0, 7, 0);
        ObstacleGenerator2.transform.position = new Vector3(2, 5, 0);
        ObstacleGenerator3.transform.position = new Vector3(-2, 9, 0);
        ObstacleGenerator4.transform.position= new Vector3(1, 6, 0);
        ObstacleGenerator5.transform.position = new Vector3(-1, 9, 0);
    }

    void Formation4()
    {
        ObstacleGenerator.transform.position = new Vector3(0, 5, 0);
        ObstacleGenerator2.transform.position = new Vector3(2, 7, 0);
        ObstacleGenerator3.transform.position = new Vector3(-2, 7, 0);
        ObstacleGenerator4.transform.position= new Vector3(1, 9, 0);
        ObstacleGenerator5.transform.position = new Vector3(-1, 6, 0);
    }

    void Random1()
    {
        if (Timer>=Timerlimit)
        {
            Order = Random.Range(1, 4);
            Timerlimit = Timerlimit + 1;
        }

        switch (Order)
        {
           case 1:
               Formation1();
               break;
           case 2:
               Formation2();
               break;
           case 3:
               Formation3();
               break;
           case 4:
               Formation4();
               break;
        }
    }
}
