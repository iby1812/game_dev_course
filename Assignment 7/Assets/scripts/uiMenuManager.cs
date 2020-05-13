using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uiMenuManager : MonoBehaviour
{
    private bool gameCanStart = false;

    public void play()
    {
        if(gameCanStart)
            Application.LoadLevel("game");
    }

    public void selectRedCar()
    {
        PlayerPrefs.SetInt("CharacterSelected", 0);
        gameCanStart = true;
    }

    public void selectYellowCar()
    {
        PlayerPrefs.SetInt("CharacterSelected" , 1);
        gameCanStart = true;
    }
}
