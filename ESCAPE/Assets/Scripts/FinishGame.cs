using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishGame : MonoBehaviour
{

    private bool gameFinished = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameFinished)
        {
            gameFinished = false;
            StartCoroutine(FinishGameAndReturnToMenu());
        }
    }

    IEnumerator FinishGameAndReturnToMenu()
    {
        yield return new WaitForSeconds(6);
        SceneManager.LoadScene("Menu");
    }

    public void GameFinished()
    {
        gameFinished = true;
    }
}
