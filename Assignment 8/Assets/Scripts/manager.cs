using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{

    public int popBallToFinishLevel;
    public Text status;

    public static int popToFinish;
    public static int ballPoped;

    // Start is called before the first frame update
    void Start()
    {
        ballPoped = 0;
        popToFinish = popBallToFinishLevel;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if (GameFinished())
        {
            NextLevel();
        }
    }

    public static bool GameFinished()
    {
        return ballPoped == popToFinish;
    }

    private void NextLevel()
    {
        status.text = "Victory";
        status.gameObject.SetActive(true);
        StartCoroutine(StartNextLevel());
    }

    IEnumerator StartNextLevel()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(1);
    }
}
