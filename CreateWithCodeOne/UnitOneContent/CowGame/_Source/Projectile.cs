using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    //Constantly move forward 
    //On hit/trigger with the tag 'Mob' debug
    
    public float ForwardSpeed = 2f;


    private void Update()
    {
    
        transform.Translate(Vector3.forward * Time.deltaTime * ForwardSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mob")
        {
            Cow cow = other.gameObject.GetComponent<Cow>();
            if (cow != null)
            {
                cow.TakeOneDamage();
            }
          
        }
    }
}
