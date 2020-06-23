using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGraveYard : MonoBehaviour
{
    [SerializeField] Text doorText;
    [SerializeField] GameObject gateOpen;
    [SerializeField] PickedItem pickedItems;
    [SerializeField] FinishGame finishGame;
    [SerializeField] GameObject victoryText;
    [SerializeField] AudioSource sawSound;

    private bool nearTheDoor = false;
    private bool openDoor = false;
    private bool foundSaw = false;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && nearTheDoor)
        {
              if (!foundSaw)
              {
                doorText.text = "LOCKED";
              }
               else
             {
                sawSound.Play();
                gateOpen.SetActive(true);
                openDoor = true;
                doorText.gameObject.SetActive(false);
                victoryText.SetActive(true);
                finishGame.GameFinished();
                Destroy(this.gameObject, 2f);
           }
        }

        if (pickedItems != null && pickedItems.pickedItemsList.Count > 0 && pickedItems.pickedItemsList["saw"])
        {
            foundSaw = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        nearTheDoor = true;
        if (!openDoor)
        {
            doorText.text = "F";
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
    }
}
