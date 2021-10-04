using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PauseMenu : MonoBehaviour
{
    public static bool GamePaused = false;
    public GameObject PauseUI;
    public GameObject GameUI;
    public GameObject OptionUI;
    void Start () 
    {
        PauseUI.SetActive(false);
        GameUI.SetActive(true);
        OptionUI.SetActive(false);
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

    public void PauseGame()
    {
        PauseUI.SetActive(true);
        GameUI.SetActive(false);
        Time.timeScale = 0f;
        GamePaused = true;
    }

    public void OpenOptions()
    {
        PauseUI.SetActive(false);
        OptionUI.SetActive(true);
    }
    public void CloseOptions()
    {
        PauseUI.SetActive(true);
        OptionUI.SetActive(false);
    }
}
