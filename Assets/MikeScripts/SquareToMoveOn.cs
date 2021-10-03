using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareToMoveOn : MonoBehaviour
{
    // Start is called before the first frame update

    SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Box")
        {
            sprite.color = Color.red;
        }
    }
}
