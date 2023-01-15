using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class LevelWon : MonoBehaviour
{

    public void Continue(){
        SceneManager.LoadScene("LevelSelect" , LoadSceneMode.Single);
    }

}
