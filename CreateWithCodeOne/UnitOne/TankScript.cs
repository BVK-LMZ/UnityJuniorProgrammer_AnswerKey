using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public
class TankScript : MonoBehaviour 
{

  // tank properties
public
  float tank_speed = 10.0f;
public
  float tank_rotation_speed = 7.5f;

  // player input
private
  float vertical_input;
private
  float horizontal_input;

  void Start() { Debug.Log("TankScript has started"); }

  void Update() { GetInput(); }

  void FixedUpdate() { MoveTank(); }

private
  void MoveTank() 
  {
    // Move Tank
    transform.Translate(Vector3.forward * vertical_input * tank_speed *
                        Time.deltaTime); // Update V
    transform.Rotate(Vector3.up * horizontal_input * tank_rotation_speed *
                     Time.deltaTime); // Update H
  }

private
  void GetInput()
  {
    vertical_input = Input.GetAxis("Vertical");
    horizontal_input = Input.GetAxis("Horizontal");
  }
}

