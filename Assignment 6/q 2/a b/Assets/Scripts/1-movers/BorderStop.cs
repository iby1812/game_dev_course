using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderStop : MonoBehaviour
{
    static public bool hitTop = false;
    static public bool hitBottom = false;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Top"))
        {
            hitTop = true;
        }

        if (other.gameObject.CompareTag("Bottom"))
        {
            hitBottom = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Top"))
        {
            hitTop = false;
        }

        if (other.gameObject.CompareTag("Bottom"))
        {
            hitBottom = false;
        }
    }
}
