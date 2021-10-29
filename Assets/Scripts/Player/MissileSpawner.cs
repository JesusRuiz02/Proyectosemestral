using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileSpawner : MonoBehaviour
{
    public GameObject shoot2;
    public int shoot = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (shoot>0)
            {
                Instantiate(shoot2, transform.position, Quaternion.identity);
            } 
        }
       

        shoot2.transform.Translate(0, 1 * Time.deltaTime * shoot, 0);
    }
}
