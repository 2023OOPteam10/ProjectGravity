using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GameManager.isDoorOpened && collision.CompareTag("Player"))
        {
            Debug.Log("Game Clear");
        }
        else
        {
            Debug.Log("Not all keys are collected");
        }
    }
}
