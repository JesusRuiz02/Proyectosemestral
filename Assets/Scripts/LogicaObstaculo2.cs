using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LogicaObstaculo2 : MonoBehaviour
{
    public int life = 3;
    public ControllerScene controllerScene;
    public float velocidad = 3f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * velocidad * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
           Lifelost();
        }
    }

    private void Lifelost()
    {
        life--;
        Debug.Log("Lost a life");
        Debug.Log(life);
        
        if (life == 0)
        {
            Debug.Log("Perdiste");
        }

        

    }

}
