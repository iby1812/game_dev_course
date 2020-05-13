using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class keyboardMover : MonoBehaviour
{

    public GameObject explosion;
    public uiManager ui;
    Vector3 position;
    public float speed;
    public AudioManager am;

    void Awake()
    {
        am.carSound.Play();
    }

    

    // Start is called before the first frame update
    void Start()
    {
        speed = 1.5f;
        position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {

        position.x += Input.GetAxis("Horizontal") * 5f * Time.deltaTime * speed;
        position.x = Mathf.Clamp(position.x, -2.7f, 2.7f);
       
            transform.position = position;
        

    
       
   
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Enemy Car")
        {
            am.carCrash.Play();
            am.carSound.Stop();
            Instantiate(explosion, transform.position, transform.rotation = Quaternion.identity);
            Destroy(this.gameObject);
            Destroy(collision.gameObject);
            ui.gameOverText.gameObject.SetActive(true);
            ui.gameOverActivate();
        }

        
    }

    

}
