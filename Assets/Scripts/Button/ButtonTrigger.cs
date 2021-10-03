using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonTrigger : MonoBehaviour
{
    public UnityEvent buttonPress;
    public UnityEvent buttonRelease;

    [SerializeField] private GameObject interactor;
    public bool isPressed;
    private bool isReleased;

    private void Awake()
    {
        isPressed = false;
        isReleased = false;
        if (buttonPress == null)
        {
            buttonPress = new UnityEvent();
        }

        if (buttonRelease == null)
        {
            buttonRelease = new UnityEvent();
        }
    }
    
    //Events
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log(other.gameObject);
        Debug.Log(interactor);
        if (other.gameObject == interactor)
        {
            isPressed = true;
            isReleased = false;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == interactor)
        {
            isPressed = false;
            isReleased = true;
        }
    }
    
    public void OnInteract()
    {
        
        if (isPressed)
        {
            buttonPress.Invoke();
        }
        else if (isReleased)
        {
            buttonRelease.Invoke();
        }
    }
    
    void Update()
    {
        OnInteract();
    }
    
    //Methods
    
    //Getters and Setters
    public bool getIsPressed()
    {
        return isPressed;
    }
}