using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelSelector : MonoBehaviour
{
    public Button[] levelButtons;
    void Start(){
      // PlayerPrefs.DeleteAll();
        int levelReached= PlayerPrefs.GetInt("levelReached",1); // level that player has reached 
                                                                //default level reached is 1
        for(int i=0;i<levelButtons.Length;i++){
            if(i+1 > levelReached){  // if level is greater than player reached then disable
                levelButtons[i].interactable=false;
            }
            
        }
    }
    public void Select (string levelName){
        SceneManager.LoadScene(levelName); 
    }

    public void GoBack(){
         SceneManager.LoadScene("MainMenu");
    }
}
