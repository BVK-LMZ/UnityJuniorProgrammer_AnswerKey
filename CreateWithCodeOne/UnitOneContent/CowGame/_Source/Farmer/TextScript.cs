using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TextScript : MonoBehaviour
{
   //confirm text mesh pro is valid
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        //set the text to the score
        scoreText.text = "Score: " + PlayerPrefs.GetFloat("FarmerKillScore", 0).ToString();
    }

    // Update is called once per frame
  
}
