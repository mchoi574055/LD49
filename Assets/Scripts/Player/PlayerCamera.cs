using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCamera : MonoBehaviour
{

    [SerializeField] private Transform player;
    private Vector2 cameraSize;
    private Vector2 maxDistance;
    private float screenToWorldFactor = 1f;
    
    // Start is called before the first frame update
    void Start()
    {
        try
        {
            Camera cam = Camera.main;
            float cameraHeight = cam.orthographicSize;
            cameraSize = new Vector2(cameraHeight * cam.aspect, cameraHeight);
            maxDistance = cameraSize * screenToWorldFactor;
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 playerPos = player.position;
        Vector3 cameraPos = transform.position;
        
        if (Math.Abs(cameraPos.x - playerPos.x) > maxDistance.x)
        {
            transform.position = new Vector3(playerPos.x + (maxDistance.x * (cameraPos.x > playerPos.x ? 1 : -1)), cameraPos.y, cameraPos.z);
        }
        if (Math.Abs(cameraPos.y - playerPos.y) > maxDistance.y)
        {
            transform.position = new Vector3(cameraPos.x, playerPos.y + (maxDistance.y * (cameraPos.y > playerPos.y ? 1 : -1)), cameraPos.z);
        }
    }
}
