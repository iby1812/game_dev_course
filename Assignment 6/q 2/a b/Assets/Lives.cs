using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Lives : MonoBehaviour
{
   
    private int number = 3;
 

    void Start()
    {
        
 
    }

    public int GetNumber()
    {
        return this.number;
    }

    public void SetLowerLive()
    {
        this.number--;
        
       
    }

    public bool ShouldFinishGame()
    {
        if(number == 0)
        {
            return true;
        }
        return false;
    }
}
