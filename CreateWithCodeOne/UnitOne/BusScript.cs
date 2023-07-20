using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public
class BusScript : MonoBehaviour 
{

public
  float bus_speed = 5.0f;

  void Update() {
    transform.Translate(Vector3.forward * bus_speed * Time.deltaTime);
  }
}
