using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()  // onclicking the playgame, displaying the story scene
    {
        SceneManager.LoadScene("Story"); 
    }

    public void ExitGame(){  // Exit from the game
        Application.Quit();
        Debug.Log("Game Ended");
    }

    public void Reload(){
        PlayerPrefs.DeleteAll();
    }
}
