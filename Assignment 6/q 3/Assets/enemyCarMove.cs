﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyCarMove : MonoBehaviour
{

    public float speed=5f;


    // Start is called before the first frame update
    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0f,speed*1f*Time.deltaTime,0f);
    }
}
