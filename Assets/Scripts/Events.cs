using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("RiverScene");
    }

    public void QuitGame()
    {
       
        SceneManager.LoadScene("MainMenu");
    }
}
