using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pump : MonoBehaviour
{
    private float x = 1, y = 1, z = 1;
    private int dir = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3( x  , y , z ) ;
        if(x > 7f && dir > 0)
        {
            dir *= -1;
        }
        else if(x<1f && dir < 0)
        {
            dir *= -1;
        }
        x += dir*0.1f;
        y += dir*0.1f;
        z += dir*0.1f;
    }
}
