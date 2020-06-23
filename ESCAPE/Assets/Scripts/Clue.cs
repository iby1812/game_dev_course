using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clue : MonoBehaviour
{

    [SerializeField] Item scrollItem;
    [SerializeField] GameObject scrollClue;

    private bool showClue = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && scrollItem.IsPlayerNearItem())
        {
            scrollClue.SetActive(showClue);
            showClue = !showClue;
        }

        if (!scrollItem.IsPlayerNearItem())
        { 
            scrollClue.SetActive(false);
            showClue = true;
        }
    }
}
