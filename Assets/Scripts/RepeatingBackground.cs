using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBackground : MonoBehaviour
{
    private BoxCollider2D groundCollider;
    private float groundVerticalLength;

    private void Awake()
    {
        groundCollider = GetComponent<BoxCollider2D>();
    }
    // Start is called before the first frame update
    void Start()
    {
        groundVerticalLength = groundCollider.size.y;
    }

    private void RepostionBackground()
    {
        transform.Translate(Vector2.up * groundVerticalLength * 1.99f);
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -groundVerticalLength)
        {

            RepostionBackground();
        }
    }
}
