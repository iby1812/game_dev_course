using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clock : MonoBehaviour
{
    private float posx = 20, posz = 0;
    float timecounter = 0;
    int dir = -1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            dir = -1;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            dir = 1;
        }
        timecounter = timecounter + dir * Time.deltaTime;


        posx = Mathf.Cos(timecounter)*5;
        posz = Mathf.Sin(timecounter)*5;
        transform.position = new Vector3( posx+20, 0,  posz);
    }
}
