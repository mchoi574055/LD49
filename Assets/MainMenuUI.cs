using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuUI : MonoBehaviour
{

    public GameObject OptionUI;
    public GameObject TitleUI;
    void Start () 
    {
        OptionUI.SetActive(false);
        TitleUI.SetActive(true);
    }

    public void MainOpenOptions()
    {
        OptionUI.SetActive(true);
        TitleUI.SetActive(false);
    }

    public void MainCloseOptions()
    {
        OptionUI.SetActive(false);
        TitleUI.SetActive(true);
    }
    
}
