using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    public void Disable()
    {
        Debug.Log(gameObject.name+" is disabled");
        gameObject.SetActive(false);
    }

    public void Enable()
    {
        Debug.Log(gameObject.name + " is enabled");
        gameObject.SetActive(true);
    }
}
