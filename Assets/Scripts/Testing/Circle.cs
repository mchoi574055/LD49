using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    // Start is called before the first frame update
    Rigidbody2D _rb;

    Vector2 vel;

    void Start()
    {
        _rb = GetComponent<Rigidbody2D>();
        vel = new Vector2(5, 0);
        _rb.velocity = vel;
        transform.tag = "Circle";

    }

    // Update is called once per frame
    void Update()
    {
    }
}
