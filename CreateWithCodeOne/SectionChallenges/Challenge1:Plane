using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// NOTE:
// For this script to work:
// 1. Attach the camera as a child to the plane game object.
// 2. Add code to the propeller game object to make it spin.
// also the plane movement is inverted like a real plane!
public class PlayerControllerX : MonoBehaviour
{
    // Configuration parameters
    public float speed = 0.2f;               // Initial speed
    public float rotationSpeed = 200;        // Speed of rotation

    // State variables
    private float verticalInput;             // Input for vertical movement

    // FixedUpdate is called once per frame
    void FixedUpdate()
    {
        // Get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");

        // Move the plane forward at a constant rate
        transform.Translate(Vector3.forward * speed); //constatly MovePlaneForward

        // Tilt the plane up/down based on up/down arrow keys
        TiltPlaneUpDown();
    }


    // Function to tilt the plane up/down based on up/down arrow keys
    void TiltPlaneUpDown()
    {
        // Vector3.right is a shorthand for writing Vector3(1, 0, 0)
        // Multiplying this with verticalInput and rotationSpeed 
        // tilts the plane up/down
        transform.Rotate(Vector3.right * verticalInput * rotationSpeed * Time.deltaTime);
    }
}
