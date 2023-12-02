using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrier : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
