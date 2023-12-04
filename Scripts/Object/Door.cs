using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private int clearCount = 0;
    private bool isBlueArrived = false;
    private bool isGreenArrived = false;
    [SerializeField] GameObject ClearCanvas;
    [SerializeField] Pause pause;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GameManager.isDoorOpened && collision.GetComponent<BluePlayer>() && !isBlueArrived)
        {
            isBlueArrived = true;
            clearCount++;
        }
        if (GameManager.isDoorOpened && collision.GetComponent<GreenPlayer>() && !isGreenArrived)
        {
            isGreenArrived = true;
            clearCount++;
        }
    }

    private void Update()
    {
        if(clearCount == 2)
        {
            pause.PauseGame();
            ClearCanvas.SetActive(true);
        }
    }
}
