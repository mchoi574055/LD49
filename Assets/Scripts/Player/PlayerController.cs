using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float accelerationSpeed = 4f;

    private Vector3 direction;
    private Rigidbody2D rb;
    private Animator animator;
    private SpriteRenderer spriteRenderer;

    private Item currentItem;

    // Start is called before the first frame update
    void Start()
    {
        direction = Vector3.zero;
        rb = gameObject.GetComponent<Rigidbody2D>();
        animator = gameObject.GetComponent<Animator>();
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        currentItem = Item.NONE;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        rb.velocity = Vector3.Lerp(rb.velocity, direction * moveSpeed, Time.deltaTime * accelerationSpeed);
        if (direction != Vector3.zero)
        {
            animator.Play("playerRight");
            spriteRenderer.flipX = direction.x < 0;
        }
        else
        {
            animator.Play("playerIdle");
        }
    }
    
    //Events
    public void OnMove(InputValue movementValue)
    {
        direction = new Vector3(movementValue.Get<Vector2>().x, movementValue.Get<Vector2>().y, 0);
    }
    
    //Getters and Setters
    public Item getCurrentItem()
    {
        return currentItem;
    }

    public void setCurrentItem(Item i)
    {
        currentItem = i;
    }
}
