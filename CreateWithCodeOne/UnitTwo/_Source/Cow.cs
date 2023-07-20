using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Cow : MonoBehaviour
{
    public float Speed;
    public float Health;

    private FarmerScore farmer_score; // Reference to the FarmerStats script

    private void Awake()
    {
        SetUp();
        farmer_score = FindObjectOfType<FarmerScore>(); // Finds the FarmerStats in the scene
        if (farmer_score == null)
        {
            Debug.LogError("No FarmerStats found in the scene.");
        }
        
        //Destroy self after 7 seconds
       Invoke("DeSpawnSelf",8.0f);
    }

    private void DeSpawnSelf()
    {
        Destroy(gameObject);
    }


    private void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * Speed);
    }

    protected void SetUp()
    {
        Health = Random.Range(1, 3);//1-2
        Speed = Random.Range(1,5);//1-4
    }

    public void TakeOneDamage()
    {   
        Debug.Log ($"Some cow took damage, new health {Health}");
        Health--;
        
        
        
        if (Health <= 0)
        {
            OnDeath();
        }
    }

    public void OnDeath()
    {
        farmer_score.SetFarmerKillScore(farmer_score.GetFarmerKillScore() + 1);
        Debug.Log("some cow died, mooo");
        Debug.Log($"Farmer kill score: {farmer_score.GetFarmerKillScore()}");
        Destroy(gameObject);
    }
    
    
}
