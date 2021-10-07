using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume1 : MonoBehaviour
{
    public bool Canvas;

    // Update is called once per frame
    void Update()
    {
        if (Canvas==true)
        {
            Resume();
        }
    }

    void Resume()
    {
        Time.timeScale = 1f;
    }
}
