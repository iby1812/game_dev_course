using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

/**
 * This component destroys its object whenever it triggers a 2D collider with the given tag.
 */
public class DestroyOnTrigger2D : MonoBehaviour {
    [Tooltip("Every object tagged with this tag will trigger the destruction of this object")]
    [SerializeField] string triggeringTag;
     Lives liveNum = new Lives();
    

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(other.gameObject);
            if (liveNum.ShouldFinishGame())
            {

                Destroy(this.gameObject);

            }
            else
            {
                TextMeshPro txt = GameObject.Find("LiveNumber").GetComponent<TextMeshPro>();
                liveNum.SetLowerLive();
                txt.text = "Lives" + liveNum.GetNumber().ToString();
            }
        }
    }
}
