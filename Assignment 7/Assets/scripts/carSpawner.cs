using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{
    public GameObject[] cars;
    float timer;
    public float delayTiimer = 1f;
    public float rush = 1f;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTiimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime * rush;
        if(timer <= 0)
        {
            Vector3 carPos = new Vector3(Random.Range(-2.7f, 2.7f), transform.position.y, transform.position.z);

            Instantiate(cars[Random.Range(0,6)], carPos, transform.rotation);
            timer = delayTiimer;
        }
      
    }
}
