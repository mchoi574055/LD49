using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestButton : MonoBehaviour
{
    public bool buttonPressed = false;
    public static SpriteRenderer spRenderer;  

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("one");
        spRenderer = gameObject.GetComponent(typeof(SpriteRenderer)) as SpriteRenderer;
        Debug.Log("two");
    }

    public void press()
    {
        Debug.Log("press")
        buttonPressed = true;
        spRenderer.color = new Color(0f, 0f, 0f, 1f); // Set to opaque black
    }                                                                 
    
    public void release()
    {
        Debug.Log("press")
        buttonPressed = false;
        spRenderer.color = new Color(255f, 100f, 100f, 1f);
    }  
    
    
    // Update is called once per frame
    void Update()
    {
        
    }
}