using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player : MonoBehaviour
{
    public float speed = 4f;
    public Rigidbody2D rb;
    public float movement = 0f;
    private bool gameOver;
    public Text status;

    // Start is called before the first frame update
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxisRaw("Horizontal") * speed;
    }

    void FixedUpdate()
    {
        if(!gameOver)
            rb.MovePosition(rb.position + new Vector2(movement * Time.fixedDeltaTime, 0f));
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.collider.tag == "Ball")
        {
           gameOver = true;
           SetGameOverText();
           Restart();
        }
    }

    private void SetGameOverText()
    {
        status.text = "Game Over";
        status.gameObject.SetActive(true);
    }

    private void Restart()
    {
        StartCoroutine(RestartLevel());
    }

    IEnumerator RestartLevel()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public bool GetGameOver()
    {
        return gameOver;
    }
}
