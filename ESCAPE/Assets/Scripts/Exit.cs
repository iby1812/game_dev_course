using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Exit : MonoBehaviour
{

    [SerializeField] Text doorText;
    [SerializeField] AudioSource doorSound;

    private bool nearTheDoor = false;
    private bool openDoor = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && nearTheDoor && !openDoor)
        {
            doorText.text = "LOCKED";
        }
        if (openDoor)
        {
           
            if (transform.eulerAngles.y > 330f || transform.eulerAngles.y == 0)
            {
                if (!doorSound.isPlaying)
                {
                    doorSound.Play();
                }
                transform.Rotate(0f, -5f * Time.deltaTime, 0f);
            }
            else
            {
                doorSound.Stop();
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        nearTheDoor = true;
        if (!openDoor)
        {
            doorText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        nearTheDoor = false;
        doorText.gameObject.SetActive(false);
        doorText.text = "F";
    }

    public void OpenDoor()
    {
        openDoor = true;
        doorText.gameObject.SetActive(false);
    }
}
