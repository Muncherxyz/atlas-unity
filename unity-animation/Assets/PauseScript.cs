using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseScript : MonoBehaviour
{
    public static bool GameIsPaused = false;
    public GameObject PauseCanvas;

    void Update()
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

    void Resume()
    {
        PauseCanvas.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        PauseCanvas.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
}
