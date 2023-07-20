using System;
using UnityEngine;

public class FarmerHealth : MonoBehaviour
{
    public float TheFarmerHealth = 100;
    public bool bIsFarmerAlive = true;
    private Rigidbody rb;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Mob"))
        {
            // Perform actions or trigger hit for the mob object
            Debug.Log("Collision with Mob detected!");
            FarmerTakeDamage();
        }
        Debug.Log("Collision detected!");
    }

    private void Awake()
    {
rb = GetComponent<Rigidbody>();
    }
    //on collsion


    public void FarmerTakeDamage()
    {
        bIsFarmerDead(bIsFarmerAlive);
        TheFarmerHealth -= 1;
    }

    public bool bIsFarmerDead(bool farmerstatus)
    {
        if (TheFarmerHealth <= 1)
        {
            farmerstatus = true;
            OnDeath();
        }
        else
        {
            farmerstatus = false;
        }

        return farmerstatus;
    }
    
    public void OnDeath()
    {
        Debug.Log("Farmer is dead");
        rb.constraints = RigidbodyConstraints.None;
        rb.AddForce(Vector3.up * 100000);
    }
}