using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    [SerializeField] GameObject ClearCanvas;
    [SerializeField] Pause pause;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GameManager.isDoorOpened && collision.CompareTag("Player"))
        {
            pause.PauseGame();
            ClearCanvas.SetActive(true);
        }
        else
        {
            Debug.Log("Not all keys are collected");
        }
    }
}
