using System;
using UnityEngine;

/// <summary>
/// Simply move this bullet to the left
/// </summary>

public class MoveLeft : MonoBehaviour
{
    public float Speed = 2.0f;
    public float TimeTillDestroy = 16.0f;
    [SerializeField] private FarmerMovement _playerReff;
    
    void Start()
    {
        Destroy(gameObject, TimeTillDestroy);
        GameObject.Find("Player").GetComponent<FarmerMovement>();//Find the component Player in the scene higharchy and get their component of tpy efarmermovement
    }

    private void Update()
    {
        // move the object left relative to its local orientation
        transform.Translate(-transform.right * (Speed * Time.deltaTime));
        
    }
}