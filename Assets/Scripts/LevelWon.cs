using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelWon : MonoBehaviour
{

    public void Continue(){  
                   
        /* when a player clicks continue buttion ,loading levelselect scene if the player won the level */

        SceneManager.LoadScene("LevelSelect" , LoadSceneMode.Single);
    }

}
