using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ResetButton : MonoBehaviour
{
    string toReload;
    void Start()
    {
        Scene scene = gameObject.scene;
        toReload = gameObject.scene.name;
        Debug.Log("Reloaded Scene");
    }
    public void resetPressed()
    {
        SceneManager.LoadScene(toReload);
    }
}
