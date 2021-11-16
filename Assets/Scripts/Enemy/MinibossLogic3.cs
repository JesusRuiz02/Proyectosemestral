using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinibossLogic3 : MonoBehaviour
{
    public GameObject enemyshoot;

    public float timer;
    // Start is called before the first frame update
    void Start()
    {
       // repeat();
      // repeat2();
        repeatshoot();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 4.3)
        {
            transform.Translate(0,-1*Time.deltaTime*0.5f,0);
        }
        else if (transform.position.y<4.3)
        {
            transform.Translate(0,1*Time.deltaTime*0.5f,0);
        }

       
        timer += Time.deltaTime;

        if (timer>=30)
        {
            destroy();
        }

        
    }

    void createshoot()
    {
        Instantiate(enemyshoot, transform.position, Quaternion.identity);
    }

    void repeatshoot()
    {
        InvokeRepeating("createshoot",1.5f,2);
    }

    void movementright()
    {
        transform.Translate(1*Time.deltaTime*0.3f,0,0);
    }

    void repeat()
    {
        InvokeRepeating("movementright",15,5);
    }

    void movementleft()
    {
        transform.Translate(-1*Time.deltaTime*0.3f,0,0);
    }

    void repeat2()
    {
        InvokeRepeating("movementleft",5,5);
    }
    public void destroy()
    {Destroy(this.gameObject);}
}
