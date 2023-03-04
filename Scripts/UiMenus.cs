using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UiMenus : MonoBehaviour
{
    public GameObject PausePanel;

    public void ContinueGame()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;

    }

    public void RestartGame()
    {

        SceneManager.LoadScene("Level1");
    }

    public void ReloadGame()
  {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
  }

    public void NextLevel()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.buildIndex+1);
    }

    public void QuitGame()

    {
        Application.Quit();
        
    }

}
