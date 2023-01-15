using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Instructions : MonoBehaviour
{
    public void Goback(){
        SceneManager.LoadScene("Story"); 
    }

    public void GoBackToMain(){
        SceneManager.LoadScene("MainMenu"); 
    }

    public void Instruct(){
        SceneManager.LoadScene("Instructions"); 
    }
}
