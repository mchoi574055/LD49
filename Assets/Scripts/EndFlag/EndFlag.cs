using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    [SerializeField] private GameObject interactor;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == interactor)
        {
            transform.Find("Canvas").gameObject.SetActive(true);
        }
    }
}
