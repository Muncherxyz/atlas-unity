using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject PauseCanvas;
    private bool GameIsPaused = false;

    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else{
                Pause();
            }
        }
    }
    public void Pause()
    {
        PauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

   public void Resume()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
}
