using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI textDisplay;
    [SerializeField] private float revealPercentage;
    
    private string currentSentence = "";

    public void setCurrentSentence(string s)
    {
        currentSentence = s;
    }

    private void Update()
    {
        textDisplay.text = currentSentence.Substring(0, (int) (currentSentence.Length * revealPercentage));
    }
        
}
