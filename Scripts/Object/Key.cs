using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    // Start is called before the first frame update
    public const int MAX_KEY = 3;
    public static int cnt_key;

    void Start()
    {
        cnt_key = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void GetKey()
    {
        cnt_key++;
    }

    public static bool HasAllKeys()
    {
        if (cnt_key == MAX_KEY)
        {
            return true;
        }
        return false;
    }
}
