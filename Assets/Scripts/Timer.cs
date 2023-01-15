using UnityEngine;
using TMPro;
using System.Collections;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{   
    // private float timerDuration = 3f * 60f;

    public float timer = 60;

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
            Debug.Log("Change Color");
            StartCoroutine(ChangeColor());
        }
        timeText.text = "00:00";
        
    }
    }

    public IEnumerator ChangeColor(){
      yield return new WaitForSeconds(2f);
     SceneManager.LoadScene("GameExit" , LoadSceneMode.Single);
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
