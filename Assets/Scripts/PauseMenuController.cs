using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{

    public void Restart()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
        Time.timeScale = 1;
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void ShowPause()
    {
        Time.timeScale = 0;
        this.gameObject.SetActive(true);
    }

    public void HidePause()
    {
        Time.timeScale = 1;
        this.gameObject.SetActive(false);
    }
}
