using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MiniMenu : MonoBehaviour
{

    [SerializeField] GameObject miniMenu;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ActivateMenu();
        }
    }

    public void ActivateMenu()
    {
        Time.timeScale = 0f;
        miniMenu.SetActive(true);
    }

    public void Resume()
    {
        miniMenu.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
