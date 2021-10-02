using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionTrigger : MonoBehaviour
{
    public UnityEvent interacted; 
    
    [SerializeField] private GameObject interactor;
    private bool isActive;

    private void Awake()
    {
        isActive = false;
        if (interacted == null)
        {
            interacted = new UnityEvent();
        }
    }
    
    //Events
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == interactor)
        {
            isActive = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject == interactor)
        {
            isActive = false;
        }
    }
    
    public void OnInteract()
    {
        if (isActive)
        {
            interacted.Invoke();
        }
    }
    
    //Methods
    
    //Getters and Setters
    public bool getIsActive()
    {
        return isActive;
    }
}
