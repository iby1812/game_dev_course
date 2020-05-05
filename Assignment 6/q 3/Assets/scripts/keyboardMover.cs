using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardMover : MonoBehaviour
{



    Vector3 position;
    // Start is called before the first frame update
    void Start()
    {
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        position.x += Input.GetAxis("Horizontal") * 5f * Time.deltaTime;
        position.x = Mathf.Clamp(position.x, -2.2f, 2.2f);

        transform.position = position;


    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy Car")
        {
            Destroy(this.gameObject);
        }
    }
}
