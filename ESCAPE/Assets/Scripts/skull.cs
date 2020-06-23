using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class skull : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void FixedUpdate()
    {
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            transform.LookAt(other.GetComponent<FirstPersonController>().transform.position);

        }
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Player")
        {
            transform.LookAt(other.GetComponent<FirstPersonController>().transform.position);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        //transform.LookAt(new Vector3(3.9f,1.8f,1.9f));
    }
}
