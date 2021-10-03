using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

public class TextFeed : MonoBehaviour
{
    [SerializeField] Text dialogue_text;
    string myFilePath, fileName;
    string[] textLines;

    // Start is called before the first frame update
    void Start()
    {
        fileName = "sampletext.txt";
        myFilePath = Application.dataPath + '/' + fileName;
        textLines = File.ReadAllLines(myFilePath);
    }
    public void Dialogue ()
    {
        foreach(string line in textLines)
        {
            if (line.Length > 40)
            {
                int length = line.Length;
                int i = 0;
                for(i = 0; i < length; i += 40, length -= 40)
                {
                    dialogue_text.text += line.Substring(i, 40) + "\n";
                }
                dialogue_text.text += line.Substring(i, length) + "\n";
            }
            else
                dialogue_text.text += line + "Normal" + "\n";
        }
    }

    public void Requiem ()
    {
        Dialogue();
    }
}
