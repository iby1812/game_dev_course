using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trackmover : MonoBehaviour
{
    public float speed;
    Vector2 offset;
    public uiManager ui;
   
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        offset = new Vector2(0f,Time.time*speed);
        GetComponent<Renderer>().material.mainTextureOffset = offset;
       
    }

    public void speedUp()
    {
        speed += 0.1f;
        speed = Mathf.Clamp(speed, 0.5f, 1.0f);
    }
}
