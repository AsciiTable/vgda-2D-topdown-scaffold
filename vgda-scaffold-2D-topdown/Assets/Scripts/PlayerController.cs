using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // The speed at which the player moves
    // Does not matter what the value is here because it can be changed in the inspector
    [SerializeField] protected float speed = 0.0f;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        // Reads input from the right or left arrow keys AND from the a and d keys
        // Input.GetAxis("Horizontal") returns 0 if nothing is pressed, 1 if the right/d key is pressed, and -1 if the left/a key is pressed
        float horizontal = Input.GetAxis("Horizontal");
        // Reads input from the up or down arrow keys AND from the w and s keys
        // Input.GetAxis("Vertical") returns 0 if nothing is pressed, 1 if the up/w key is pressed, and -1 if the down/s key is pressed
        float vertical = Input.GetAxis("Vertical");
        // Saves the position at which the player is currently at in that frame
        Vector2 position = transform.position;
        // Update the horizontal position of the player based on input
        position.x = position.x + (speed * horizontal * Time.deltaTime);
        // Update the vertical position of the player based on input
        position.y = position.y + (speed * vertical * Time.deltaTime);
        // Sets the position of the player to the updated position
        transform.position = position;
    }
}
