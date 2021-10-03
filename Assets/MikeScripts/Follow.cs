using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform toFollow;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        transform.position = toFollow.position + (10 * Vector3.back);
    }
}
