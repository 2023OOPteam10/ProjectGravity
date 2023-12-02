using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeUI;

    private void Start()
    {
        timeUI.color = Color.black;
    }

    public void TimeUpdate(float timeleft)
    {
        if(timeleft > 0)
        {
            int min = (int)timeleft / 60;
            int sec = (int)timeleft % 60;

            timeUI.text = $"{min}:{sec}";
        }

        else
        {
            timeUI.text = "0:0";
            timeUI.color = Color.red;
        }
    }
}
