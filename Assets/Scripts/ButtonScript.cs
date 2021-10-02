using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonScript : MonoBehaviour
{
    public bool buttonPressed = false;
    public Text pressed;
    
    public void buttonClick()
    {
        pressed.text = "1";
        buttonPressed = true;
    }

    public void release()
    {
        pressed.text = "0";
        buttonPressed = false;
    }
}
