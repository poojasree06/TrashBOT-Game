using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Instructions : MonoBehaviour
{
    public void Goback(){                  /* going back to story scene */
        SceneManager.LoadScene("Story"); 
    }

    public void GoBackToMain(){           /* going back to main menu  scene */
        SceneManager.LoadScene("MainMenu"); 
    }

    public void Instruct(){           /* going to instructions scene */ 
        SceneManager.LoadScene("Instructions"); 
    }
}
