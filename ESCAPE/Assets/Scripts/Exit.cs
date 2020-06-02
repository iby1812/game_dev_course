using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{

    [SerializeField] Text doorText;

    private bool nearTheDoor = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && nearTheDoor)
        {
            doorText.text = "LOOKED";
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        nearTheDoor = true;
        doorText.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        nearTheDoor = false;
        doorText.gameObject.SetActive(false);
        doorText.text = "F";
    }

    
}
