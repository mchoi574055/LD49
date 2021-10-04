using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Door : MonoBehaviour
{
    public UnityEvent opened;
    
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject key;
    
    // Start is called before the first frame update
    void Start()
    {
        if (opened == null)
        {
            opened = new UnityEvent();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   private void OnTriggerEnter2D(Collider2D other)
   {
       PlayerController playerController = player.GetComponent<PlayerController>();
       if(other.gameObject == player)
       {
            if (playerController.getCurrentItem() == Item.KEY) { 
                gameObject.SetActive(false);
                playerController.setCurrentItem(Item.NONE);
                key.SetActive(false);
                opened.Invoke();
            }
       }
   }
}
