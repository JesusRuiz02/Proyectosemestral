using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;


public class Playerlives
{
    public int lives;
}
public class WinCondition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int level = 10;
        Playerlives lives = new Playerlives() {lives = 3};
        string livesString = "3";
        AnalyticsResult result = Analytics.CustomEvent("PlayerPassLevel", new Dictionary<string, object>(){
        {"level", level},
        {"lives", livesString}
        });
                Debug.Log("Result : " + result.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
