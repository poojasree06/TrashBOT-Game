using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void Restart(){
        int a=PlayerPrefs.GetInt("levelReached",1);
        Debug.Log(a);
        if(a==1){
            RestartLevel01();
        }else if(a==2){
            RestartLevel02();
        }else if(a==3){
            RestartLevel03();
        }else if(a==4){
            RestartLevel04();
        }
    }
    public void RestartLevel01(){
        SceneManager.LoadScene("Level01");
    }

    public void RestartLevel02(){
        SceneManager.LoadScene("Level02");
    }

    public void RestartLevel03(){
        SceneManager.LoadScene("Level03");
    
    }
    public void RestartLevel04(){
        SceneManager.LoadScene("Level04");
    }

    public void QuitGame()
    {
       
        SceneManager.LoadScene("LevelSelect");
    }
}
