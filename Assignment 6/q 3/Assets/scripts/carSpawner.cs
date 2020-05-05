using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawner : MonoBehaviour
{
    public GameObject car;
    float timer;
    public float delayTiimer = 1f;

    // Start is called before the first frame update
    void Start()
    {
        timer = delayTiimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Vector3 carPos = new Vector3(Random.Range(-2.2f, 2.2f), transform.position.y, transform.position.z);

            Instantiate(car, carPos, transform.rotation);
            timer = delayTiimer;
        }
      
    }
}
