using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    float inputX, inputZ;
    // Update is called once per frame
    void Update()
    {


        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {

            inputZ = Input.GetAxis("Vertical");
        }
        else
        {
            inputZ = 0;
        }

        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D))
        {
            inputX = Input.GetAxis("Horizontal");

        }
        else
        {
            inputX = 0;
        }


        if (inputX != 0)
        {
            rotate();
        }
        if (inputZ != 0)
        {
            move();
        }
    }

    private void move()
    {
        transform.position += transform.forward * inputZ * Time.deltaTime * 2f;
    }
    private void rotate()
    {
        transform.Rotate(new Vector3(0f, inputX * 2f, 0f));
    }
}
