using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawner : MonoBehaviour
{
    public GameObject shoot2;
    public int shoot = 3;

    public GameObject bullet;
    public GameObject bullet1;
    public GameObject bullet2;
    public float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        bool dispara;

        dispara = Input.GetButtonDown("Fire1");

        if (dispara) Shooot();
       
        

       

        if (transform.position.y>20)
        {
            Destroyshoot();
        }

        if (shoot==3)
        {
            bullet.gameObject.SetActive(true);
            bullet1.gameObject.SetActive(true);
            bullet2.gameObject.SetActive(true);
        }
        else if (shoot==2)
        {
            bullet.gameObject.SetActive(true);
            bullet1.gameObject.SetActive(true);
            bullet2.gameObject.SetActive(false);
        }
        else if (shoot==1)
        {
            bullet.gameObject.SetActive(true);
            bullet1.gameObject.SetActive(false);
            bullet2.gameObject.SetActive(false);
        }
        else if (shoot==0)
        {
            bullet.gameObject.SetActive(false); 
            bullet1.gameObject.SetActive(false);
            bullet2.gameObject.SetActive(false);
        }

        if (shoot<=0)
        {
            timer += Time.deltaTime;
        }

        if (timer>=10)
        {
            shoot = 3;
        }
    }

    public void Destroyshoot()
    {
        
        Destroy(this.gameObject);
    }

    public void Shooot()
    {
        if (shoot>0)
        {
            Instantiate(shoot2, transform.position, Quaternion.identity);
            shoot--;
        } 
    }
    
}
