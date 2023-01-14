using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{public static Score instance;
    public TextMeshProUGUI scoreText;
    Timer time;
    [SerializeField] GameObject Timer;
     int score = 0;
     int goal=30;

     private void Awake()
     {
        instance = this;
       // time = Timer.GetComponent<Timer>();
     }
    void Start()
    {
        scoreText.text = "SCORE: "+score.ToString();
    }

    
    public void AddPoint()
    {
        score += 1; 
        if(score == goal)
        {
          SceneManager.LoadScene("GameExit" , LoadSceneMode.Single);
        }
        scoreText.text = "SCORE: "+score.ToString();
    }

}
