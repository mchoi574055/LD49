using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
    private readonly string[] _iterations = {"Iteration1", "Iteration2", "Iteration3", "Iteration4", "Iteration5", "To be continued"};
    
    public void pressedPlay()
    {
        Debug.Log("Detected press");
        SceneManager.LoadScene(_iterations[PlayerPrefs.GetInt("level")]);
    }
}
