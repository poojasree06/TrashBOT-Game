using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/* selecting the levels */ 

public class LevelSelector : MonoBehaviour
{

    public Button[] levelButtons;
    void Start(){
       //PlayerPrefs.DeleteAll();
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
         /* by passing levelname as parameter ,it loads that level scene into the screen */
    }

    public void GoBack(){
         SceneManager.LoadScene("MainMenu");
         /* going back to the main menu */
    }
}
