using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
   /* private void open()
    {
        gameObject.SetActive(false); //Door opens, so it's deleted.
    }
   */

   private void OnTriggerEnter2D(Collider2D other)
   {
       Debug.Log("Hi");
       // player = collider.gameObject.GetComponent<PlayerController>();
        if (other.gameObject == player)
        {
            
          //  if (player.getCurrentItem() == Item.KEY) // If the player near the door is holding a key, open.
           // {
                gameObject.SetActive(false);
          //  }
        }
   }
}
