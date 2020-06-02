using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuManager : MonoBehaviour
{

    [SerializeField] AudioClip clickSound;
    [SerializeField] AudioClip hoverSound;

    private AudioSource audio;

    // Start is called before the first frame update
    void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Tutorial");
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void ClickSound()
    {
        audio.clip = clickSound;
        audio.Play();
    }

    public void HoverSound()
    {
        audio.clip = hoverSound;
        audio.Play();
    }

}
