using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Events;

public class Button : MonoBehaviour
{
    private SpriteRenderer spRenderer;

    [SerializeField] private GameObject[] interactors;
    [SerializeField] private Sprite pushed;
    [SerializeField] private Sprite released;
    
    public UnityEvent buttonPress;
    public UnityEvent buttonRelease;

    // Start is called before the first frame update
    void Start()
    {
        spRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (buttonPress == null)
        {
            buttonPress = new UnityEvent();
        }

        if (buttonRelease == null)
        {
            buttonRelease = new UnityEvent();
        }
    }
    
    //Methods
    public void press()
    {
        spRenderer.sprite = pushed;
    }                                                                 
    
    public void release()
    {
        spRenderer.sprite = released;
    }
    
    //Events
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (interactors.Contains(other.gameObject))
        {
            buttonPress.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (interactors.Contains(other.gameObject))
        {
            buttonRelease.Invoke();
        }
    }
}