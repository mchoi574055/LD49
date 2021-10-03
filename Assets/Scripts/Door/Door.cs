using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
  //  [SerializeField] private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


   private void OnTriggerEnter2D(Collider2D other)
   {
      // Debug.Log("Hi");
     //  Debug.Log(other);
       PlayerController player = other.GetComponent<PlayerController>();
       if (player != null)
       {
        // Debug.Log("Hello");
         if (player.getCurrentItem() == Item.KEY)
          {
            gameObject.SetActive(false);
          }
       }
   }
}
