using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject PauseUI;
    public GameObject GameUI;

    void Start () 
    {
        PauseUI.SetActive(false);
        GameUI.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (GamePaused)
                ResumeGame();
            else
                PauseGame();
        }
    }

    public void ResumeGame()
    {
        GameUI.SetActive(true);
        PauseUI.SetActive(false);
        Time.timeScale = 1f;
        GamePaused = false;

    }

    void PauseGame()
    {
        PauseUI.SetActive(true);
        GameUI.SetActive(false);
        Time.timeScale = 0f;
        GamePaused = true;
    }

}
