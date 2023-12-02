using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timeUI;

    public void TimeUpdate(float timeleft)
    {
        int min = (int)timeleft / 60;
        int sec = (int)timeleft % 60;

        timeUI.text = $"{min}:{sec}";
    }
}
