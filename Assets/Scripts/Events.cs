using UnityEngine.SceneManagement;
using UnityEngine;

public class Events : MonoBehaviour
{
    public void RestartGame()
    {
        SceneManager.LoadScene("DemoDay");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
