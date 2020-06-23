using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class Tutorial : MonoBehaviour
{

    [SerializeField] Item itemBlockingExit;
    [SerializeField] Item axe;
    [SerializeField] Text tutorialInfo;
    [SerializeField] PickedItem ItemList;
    [SerializeField] AudioSource barrelSound;


    private bool pressedW = false;
    private bool pressedA = false;
    private bool pressedS = false;
    private bool pressedD = false;
    private bool pressedLShift = false;
    private bool pressedF = false;
    private bool pressedC = false;

    private bool moveComplete = false;
    private bool moveFastComplete = false;
    private bool pickItemComplete = false;
    private bool crouchComplete = false;

    private bool tutorialComplete = false;



    // Start is called before the first frame update
    void Start()
    {
        ShowMoveTutorial();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            pressedW = true;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pressedA = true;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pressedS = true;
        }

        if (Input.GetKey(KeyCode.D))
        {
            pressedD = true;
        }

        if (pressedW && pressedA && pressedS && pressedD && !moveComplete)
        {
            moveComplete = true;
            ShowMoveFastTutorial();
        }

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift) && moveComplete)
        {
            pressedLShift = true;
        }

        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift) && moveComplete)
        {
            pressedLShift = true;
        }

        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift) && moveComplete)
        {
            pressedLShift = true;
        }

        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift) && moveComplete)
        {
            pressedLShift = true;
        }

        if (pressedLShift && !moveFastComplete)
        {
            moveFastComplete = true;
            ShowPickItemTutorial();
        }

        if (moveFastComplete && ItemList != null && ItemList.pickedItemsList.Count > 0 && ItemList.pickedItemsList["AXE"])
        {
            pressedF = true;
        }

        if (pressedF && !pickItemComplete)
        {
            pickItemComplete = true;
            ShowCrouchTutorial();
        }

        if(Input.GetKeyDown(KeyCode.C) && pickItemComplete)
        {
            pressedC = true;
        }

        if (pressedC && !crouchComplete)
        {
            crouchComplete = true;
            ShowWayOutTutorial();
        }


        if (Input.GetKeyDown(KeyCode.F) && crouchComplete && itemBlockingExit.IsPlayerNearItem())
        {
            barrelSound.Play();
            tutorialComplete = true;
            itemBlockingExit.SetTextActive(false);
            Destroy(itemBlockingExit.gameObject, 0.5f);
            tutorialInfo.text = "Good Job! you finish the tutorial let's see you ESCAPE NOW! GOOD LUUCK!!!";
            ShowEndOfTutorial();
        }
    }

  
    private void ShowMoveTutorial()
    {
        tutorialInfo.text = "Welcome to escape tutorial..  Try to move the mouse to look around and to move press W A S D..";
        tutorialInfo.fontSize = 22;
    }

    private void ShowMoveFastTutorial()
    {
        tutorialInfo.fontSize = 25;
        tutorialInfo.text = "To move fast press W A S D with Left Shift.. ";
    }

    private void ShowPickItemTutorial()
    {
        tutorialInfo.text = "You can pick up items from the room by pressing F, find an axe and pick it up..";
    }

    private void ShowCrouchTutorial()
    {
        tutorialInfo.text = "To crouch press C..";
    }

    private void ShowWayOutTutorial()
    {
        tutorialInfo.text = "Find A Way out, try to Escape to finish the tutorial";
    }

    public void ShowEndOfTutorial()
    {
        if (tutorialComplete)
        {
            StartCoroutine(NextRoom());
        }
    }

    private IEnumerator NextRoom()
    {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene("FirstRoom");
    }

    
}
