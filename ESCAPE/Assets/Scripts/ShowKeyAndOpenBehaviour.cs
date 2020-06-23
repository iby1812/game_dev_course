using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowKeyAndOpenBehaviour : MonoBehaviour
{

    [SerializeField] GameObject key;
    [SerializeField] PickedItem itemPickedList;
    [SerializeField] Item doorLock;
    [SerializeField] Exit exitDoor;
    [SerializeField] AudioSource lockOpenedSound;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (doorLock.IsPlayerNearItem())
        {
            if (Input.GetKeyDown(KeyCode.F) && !key.active && itemPickedList != null && itemPickedList.pickedItemsList.Count > 0 && itemPickedList.pickedItemsList["keyOnFloor"]) { 
                key.SetActive(true);
            }
            if (key.active)
            {
                if (Input.GetKeyDown(KeyCode.F))
                {
                    doorLock.SetText("To Rotate Key press E or Q. Press F when finished.");
                    doorLock.SetTextSize(20);
                    if (mod(key.gameObject.transform.eulerAngles.z) >= 135f && mod(key.gameObject.transform.eulerAngles.z) <= 145f)
                    {
                        lockOpenedSound.Play();
                        exitDoor.OpenDoor();
                    }
                    
                }
                if (Input.GetKey(KeyCode.E))
                {
                    key.gameObject.transform.Rotate(0f, 0f, 25f * Time.deltaTime);
                }
                if (Input.GetKey(KeyCode.Q))
                {
                    key.gameObject.transform.Rotate(0f, 0f, -25f * Time.deltaTime);
                }
            }
        }
    }

    private float mod(float num)
    {
        return num % 360;
    }
}
