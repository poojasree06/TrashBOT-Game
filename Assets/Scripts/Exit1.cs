using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit1 : MonoBehaviour
{
    // Start is called before the first frame update

    public static bool isOver;
    public GameObject GameExit;
    public string nextLevel="Level02";
    public int levelToUnlock=2;


    void Start()
    {
        isOver=false;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Score.instance.score);
        EndGame();
       /* if(isOver){
            return;
        }else{
            EndGame();
        }*/
    }

    public void EndGame(){
        if(Score.instance.score == Score.instance.goal)
        {
          isOver=true;
       //   SceneManager.LoadScene("GameExit" , LoadSceneMode.Single);
          WinLevel();
        }
    }
    public void WinLevel(){
      Debug.Log("Level Won!");
      PlayerPrefs.SetInt("levelReached",levelToUnlock);
      int a=PlayerPrefs.GetInt("levelReached",1);
      if(a==4){
        SceneManager.LoadScene("LevelSelect" , LoadSceneMode.Single);
      }else{
        SceneManager.LoadScene("LevelWon" , LoadSceneMode.Single);
      }
     // obj.NextLevel(nextLevel);
    //  Score.instance.goal=20;
    }
}
