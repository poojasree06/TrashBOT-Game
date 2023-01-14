using UnityEngine;
using TMPro;
public class Timer : MonoBehaviour
{   
    // private float timerDuration = 3f * 60f;

    public float timer = 30;

    [SerializeField]
    private TextMeshProUGUI timeText;
    // [SerializeField]
    // private TextMeshProUGUI secondMinute;
    // [SerializeField]
    // private TextMeshProUGUI separator;
    // [SerializeField]
    // private TextMeshProUGUI firstSecond;
    // [SerializeField]
    // private TextMeshProUGUI secondSecond;

    // void Start()
    // {
    //     ResetTimer();
    // }
    void Update()
    {   if(timer > 0){
        timer -= Time.deltaTime;
        UpdateTimerDisplay(timer);
    }
    else
    {
        
        timeText.text = "00:00";
        
    }
    }
//    public float getTime(){
//      if(timer > 0){
//         timer -= Time.deltaTime;
//         UpdateTimerDisplay(timer);
//         return timer;
//     }
//     else
//     {return 0;}
//    }

    // private void ResetTimer()
    // {
    //    timer = timerDuration;
    // }
    private void UpdateTimerDisplay(float time)
    {
       float minutes = Mathf.FloorToInt(time / 60);
       float seconds = Mathf.FloorToInt(time % 60);

       timeText.text = string.Format("{00:00}:{1:00}",minutes, seconds);
    //    firstMinute.text = currentTime[0].ToString();
    //    secondMinute.text = currentTime[1].ToString();
    //    firstSecond.text = currentTime[2].ToString();
    //    secondSecond.text = currentTime[3].ToString();
    //    GUI. Label(new Rect(10,10,250,100), currentTime);

    }

    private void Flash()
    {

    }
}
