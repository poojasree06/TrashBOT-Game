using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{   
    
    public float timer = 60;              // Initialize time to 60sec

    Score a;

    void Start()
    {
    a = FindObjectOfType<Score>();           // Returns object of type Score
    }
    
    [SerializeField]
    public TextMeshProUGUI timeText;

    void Update()                        // Function which updates time
    {   if(timer > 0){
        timer -= Time.deltaTime;
        UpdateTimerDisplay(timer);
    }
    else
    {
        if(a.score!=a.goal){
            Debug.Log("Change Color");
            StartCoroutine(ChangeColor()); /* calling the Ienumerator function */
        }
        timeText.text = "00:00";
        
    }
    }

    public IEnumerator ChangeColor(){
      yield return new WaitForSeconds(2f); 

    /* wait for 2 seconds and load the scene with gameExit scene */

     SceneManager.LoadScene("GameExit" , LoadSceneMode.Single);
    }


    private void UpdateTimerDisplay(float time)                              // Function to update time apperaing on the screen as a string
    {
       float minutes = Mathf.FloorToInt(time / 60);
       float seconds = Mathf.FloorToInt(time % 60);

       timeText.text = string.Format("{00:00}:{1:00}",minutes, seconds);      // string formatting
    }

}
