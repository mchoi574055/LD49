using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToTitleScreen : MonoBehaviour
{
    public void returnToTitle()
    {
        SceneManager.LoadScene("TitleScene");
    }
}
