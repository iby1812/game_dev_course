using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{

    public float xDirection = 1f;
    public float speed = 0.1f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       

        if (xDirection > 0f)
        {
            if (transform.position.x < 5f)
            {
                speed = 10.5f + transform.position.x;
            }
            else
            {
                speed = 10.5f - transform.position.x;
            }
        }
        else
        {
            if (transform.position.x > -5f)
            {
                speed = 10.5f - transform.position.x;
            }
            else
            {
                speed = 10.5f + transform.position.x;
            }
        }
        if (transform.position.x > 10f || transform.position.x < -10f)
        {
            
            xDirection *= -1;
           
        }
        transform.Translate( speed * xDirection * 1f * Time.deltaTime, 0f, 0f);
        
        
    }
}
