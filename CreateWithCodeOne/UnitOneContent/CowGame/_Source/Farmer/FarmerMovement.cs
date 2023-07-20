using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FarmerMovement : MonoBehaviour
{
    // Public variables for the movement speed of the farmer
    public float ForwardSpeed = 20f;
    public float TurnSpeed = 200f;

    // Private variables to hold the input data
    private float _horizontalInput;
    private float _verticalInput;

    private void Update()
    {
        // Get input data from the user
        _horizontalInput = Input.GetAxis("Horizontal");
        _verticalInput = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        // Apply the input data to the farmer's movement
        transform.Translate(Time.deltaTime * Vector3.forward * _verticalInput * ForwardSpeed);
        transform.Rotate(Time.deltaTime * Vector3.up * _horizontalInput * TurnSpeed);
    }
}