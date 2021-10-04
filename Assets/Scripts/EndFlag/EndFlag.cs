using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class EndFlag : MonoBehaviour
{
    public UnityEvent finished;

    private void Start()
    {
        if (finished == null)
        {
            finished = new UnityEvent();
        }
    }

    [SerializeField] private GameObject interactor;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject == interactor)
        {
            finished.Invoke();
            transform.Find("Canvas").gameObject.SetActive(true);
            other.gameObject.SetActive(false);
            PlayerPrefs.SetInt("level", PlayerPrefs.GetInt("level") + 1);
            PlayerPrefs.Save();
        }
    }
}
