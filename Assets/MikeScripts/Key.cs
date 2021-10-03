using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    bool inside = false;

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void updatePosition()
    {
        transform.parent = GameObject.Find("Circle").transform;
        transform.localPosition = Vector3.up;
    }
    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.tag == "Circle")
        {
            inside = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "Circle")
        {
            Debug.Log("Exited");
            inside = false;
        }
    }
}
