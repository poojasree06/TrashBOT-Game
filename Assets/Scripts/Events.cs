using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("Level01");
    }

    public void QuitGame()
    {
       
        SceneManager.LoadScene("LevelSelect");
    }
}
