using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Unity.Mathematics;
using UnityEngine;

public class MinibossGenerator : MonoBehaviour
{
    public GameObject Enemy;
    // Start is called before the first frame update
    void Start()
    {
        repeat();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void instantiateboss()
    {
        Instantiate(Enemy, transform.position, quaternion.identity);
    }

    void repeat()
    {
        InvokeRepeating("instantiateboss",80,20);
    }
}
