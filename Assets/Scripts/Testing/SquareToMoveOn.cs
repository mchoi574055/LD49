using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareToMoveOn : MonoBehaviour
{
    // Start is called before the first frame update

    SpriteRenderer sprite;
    GameObject toDetect;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
        toDetect = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == toDetect.tag)
        {
            sprite.color = Color.red;   
        }
    }
}
