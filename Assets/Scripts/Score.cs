using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Score : MonoBehaviour
{public static Score instance;
    public TextMeshProUGUI scoreText;
     
     int score = 0;

     private void Awake()
     {
        instance = this;
     }
    void Start()
    {
        scoreText.text = "SCORE: "+score.ToString();
    }

    
    public void AddPoint()
    {
        score += 1;
        scoreText.text = "SCORE: "+score.ToString();
    }

}
