using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


/* exit screen */

public class Exit1 : MonoBehaviour
{
 
    public static bool isOver;
    public GameObject GameExit;
    public string nextLevel="Level02";
    public int levelToUnlock=2;


    void Start()
    {
        isOver=false;
    }

    void Update()
    {
      //  Debug.Log(Score.instance.score);
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
          WinLevel();
        }
    }
    public void WinLevel(){
      Debug.Log("Level Won!");
      PlayerPrefs.SetInt("levelReached",levelToUnlock); /* storing the gamedata into the local disk */
      int a=PlayerPrefs.GetInt("levelReached",1);  
      if(a==5){
        StartCoroutine(Completed());
      }else{
       StartCoroutine(LevelWon());
      }
    }

    /* wait for 2 seconds and show the level won scene */

    public IEnumerator LevelWon(){
      yield return new WaitForSeconds(2f);
     SceneManager.LoadScene("LevelWon");
    }

    public IEnumerator Completed(){
      yield return new WaitForSeconds(2f);
      SceneManager.LoadScene("LevelCompleted");
    }

}
