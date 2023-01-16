using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public static Score instance;              // creating a score class instance 
    public TextMeshProUGUI scoreText;
    Timer time;
    [SerializeField] GameObject Timer;        // we want timer to appear in inspector but not accessible so we used serializedfield for timer
    public int score = 0;                     // initialize goal to 0
    public int goal=10;

     private void Awake()                    // called before start to initialize instance of the class
     {
        instance = this;
     }
    void Start()                                            // used to update score appearing in the screen
    {
        scoreText.text = "SCORE: "+score.ToString();
    }

    
    public void AddPoint()                                     // Function used to increament score
    {
        score += 1; 
        scoreText.text = "SCORE: "+score.ToString();
    }


}
