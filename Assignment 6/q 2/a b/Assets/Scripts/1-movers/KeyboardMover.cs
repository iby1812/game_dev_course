using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This component moves its object when the player clicks the arrow keys.
 */

 
public class KeyboardMover: MonoBehaviour {
    private Vector3 position;
    [Tooltip("Speed of movement, in meters per second")]
    [SerializeField] float speed = 1f;

    private void Start()
    {
        position = transform.position;
    }
    void Update() {
        position.x += Input.GetAxis("Horizontal") * speed * Time.deltaTime; // +1 if right arrow is pushed, -1 if left arrow is pushed, 0 otherwise
        position.y += Input.GetAxis("Vertical") * speed * Time.deltaTime;     // +1 if up arrow is pushed, -1 if down arrow is pushed, 0 otherwise
        position.x = Mathf.Clamp(position.x, -8f,8f);
        position.y = Mathf.Clamp(position.y, -3.3f,3.8f);   
        transform.position = position;
        //transform.Translate(movementVector);
        // NOTE: "Translate(movementVector)" uses relative coordinates - 
        //       it moves the object in the coordinate system of the object itself.
        // In contrast, "transform.position += movementVector" would use absolute coordinates -
        //       it moves the object in the coordinate system of the world.
        // It makes a difference only if the object is rotated.
    }
}
