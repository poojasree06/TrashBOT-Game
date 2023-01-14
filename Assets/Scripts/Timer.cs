using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{   
    // private float timerDuration = 3f * 60f;

    public float timer = 30;

    Score a;
    void Start(){
    a = FindObjectOfType<Score>();
    }
    
    [SerializeField]
    public TextMeshProUGUI timeText;

    void Update()
    {   if(timer > 0){
        timer -= Time.deltaTime;
        UpdateTimerDisplay(timer);
    }
    else
    {
        if(a.score!=a.goal){
            SceneManager.LoadScene("GameExit" , LoadSceneMode.Single);
        }
        timeText.text = "00:00";
        
    }
    }

    private void UpdateTimerDisplay(float time)
    {
       float minutes = Mathf.FloorToInt(time / 60);
       float seconds = Mathf.FloorToInt(time % 60);

       timeText.text = string.Format("{00:00}:{1:00}",minutes, seconds);
    }

    private void Flash()
    {

    }
}
