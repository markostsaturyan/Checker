using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour {

    public void StartGame()
    {
        SceneManager.LoadScene("Checkers");
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Rules()
    {
        SceneManager.LoadScene("Rules");
    }
}
