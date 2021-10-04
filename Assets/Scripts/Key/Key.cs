using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    [SerializeField] private GameObject player;

    public void followPlayer()
    {
        player.GetComponent<PlayerController>().setCurrentItem(Item.KEY);
        transform.parent = player.transform;
        transform.localPosition = new Vector3(0f, 4.6f);
    }
}
