using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This script handles the infinite scrolling of the background by continuously moving it to the left and resetting its position after a certain point.
/// </summary>

public class MoveBackground : MonoBehaviour
{
    private Vector3 _backgroundStartPosition;
    private float _repeatWidth;
    public float Speed = 2.0f;
    private FarmerMovement _playerRef;
    
    
    
    private void Start()
    {
        _backgroundStartPosition = transform.position; //Cache where the background starts
        _repeatWidth = GetComponent<BoxCollider>().size.x / 2;
        
        _playerRef = FindObjectOfType<FarmerMovement>();
    }

    void Update()
    {   
        if (_playerRef._bIsGameOver)
        {
            return;
        }
        // Move the object left relative to its local orientation
        transform.Translate(-transform.right * (Speed * Time.deltaTime), Space.World);
        
        
        // Reset position when needed
        if (transform.position.x < _backgroundStartPosition.x - _repeatWidth)
        {
            transform.position = _backgroundStartPosition;
        } 
    }
}