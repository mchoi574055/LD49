using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreloadFunctions
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
    static void OnBeforeSceneLoadRuntimeMethod()
    {
        if (!PlayerPrefs.HasKey("level"))
        {
            PlayerPrefs.SetInt("level", 0);
            PlayerPrefs.Save();
        }
    }
}
