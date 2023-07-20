using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add this namespace

public class FarmerScore : MonoBehaviour
{
    private float farmerKillScore = 0;
    public TextMeshProUGUI scoreText; // Change this to TextMeshProUGUI

    private void Awake()
    {
      
        if (scoreText == null)
        {
            Debug.LogError("Score Text is not assigned in the inspector.");
        }
    }

    private void Start()
    {
        scoreText.text = "Score: " + farmerKillScore.ToString();
        // Retrieve the score from PlayerPrefs, or use the default value of 0 if there's no saved score yet
        farmerKillScore = PlayerPrefs.GetFloat("FarmerKillScore", 0);
        UpdateScoreText();
    }

    public float GetFarmerKillScore()
    {
        return farmerKillScore;
    }

    public void SetFarmerKillScore(float value)
    {
        farmerKillScore = value;
        PlayerPrefs.SetFloat("FarmerKillScore", farmerKillScore); // Save the score in PlayerPrefs
        UpdateScoreText();
    }

    // Update the UI Text with the current score
    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + farmerKillScore.ToString();
        }
    }

        
}