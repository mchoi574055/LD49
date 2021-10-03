using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void followPlayer()
    {
        Debug.Log("test");
        transform.parent = GameObject.Find("Circle").transform;
        transform.localPosition = Vector3.up;
    }
}
