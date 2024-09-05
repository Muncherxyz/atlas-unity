using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public AudioSource buttonClick;
    public void LevelSelect(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void quit()
    {
        Application.Quit();
        Debug.Log("Exited");
    }

    public void Click()
    {
        buttonClick.Play();
    }
}
