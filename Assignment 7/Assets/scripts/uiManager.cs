using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiManager : MonoBehaviour
{
    public Button[] buttons;
    public trackmover trackmover;
    public carSpawner carSpawner;
    public enemyCarMove [] enemyCarsMove;
    public GameObject[] playerCarsList;
    public Text scoreText;
    public Text gameOverText;
    public AudioManager am;

    int end = 0;
    int score;
    bool gameOver;
    private int nextSpeedUpScore = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        playerCarsList[1 - PlayerPrefs.GetInt("CharacterSelected")].active = false;
        score = 0;
        gameOver = false;
        InvokeRepeating("scoreUpdate", 1f, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
          
        if (score >= nextSpeedUpScore)
        {
            trackmover.speedUp();
            carSpawner.rush = Mathf.Clamp(carSpawner.rush + 0.1f, 1f, 2.5f);
            
            foreach(enemyCarMove car in enemyCarsMove)
            {
                car.speed = Mathf.Clamp(car.speed + 0.5f, 5f, 8f);
            }
            nextSpeedUpScore += 20;
        }
    }

    void scoreUpdate()
    {
        if (!gameOver)
        {
            score++;
            scoreText.text = "Score: " + score;
        }
    }

    public void gameOverActivate()
    {
        Invoke("endGame", 2);
    }

    private void endGame()
    {
        gameOver = true;
        gameOverText.gameObject.SetActive(false);
        Pause();
    }

    public int getScore()
    {
        return score;
    }

    public void Pause()
    {
            if (Time.timeScale == 0)
            {
            if (!gameOver)
            {
                Time.timeScale = 1;
                am.carSound.Play();
                foreach (Button btn in buttons)
                {
                    btn.gameObject.SetActive(false);
                }
            }
            }
            else if (Time.timeScale == 1)
            {
                Time.timeScale = 0;
                am.carSound.Stop();
                foreach (Button btn in buttons)
                {
                    btn.gameObject.SetActive(true);
                }
            }
    }

    public void Restart()
    {
        Application.LoadLevel(Application.loadedLevel);
        gameOver = false;
        Pause();
    }

    public void Menu()
    {
        Application.LoadLevel("menu");
        gameOver = false;
        Pause();
    }
}
