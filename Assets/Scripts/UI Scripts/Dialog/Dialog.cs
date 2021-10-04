using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    private string[][] blocks;
    public float typingSpeed;

    public void Start()
    {
        
    }
    
    public void playDialogueChunk(string[] s)
    {
        StartCoroutine(Type(s));
    }
    
    IEnumerator Type(string[] sentences) {
            
        int index = 0;
        
        while(index < sentences.Length - 1){
            
            foreach(char letter in sentences[index].ToCharArray()) {
                textDisplay.text += letter;
                yield return new WaitForSeconds(typingSpeed);
            }

            yield return new WaitForSeconds(3);
            
            index++;
            textDisplay.text = "";
        }
        textDisplay.text = "";
    }
        
}