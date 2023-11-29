using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class player1 : MonoBehaviour
{

    public float speed;
    public Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if(Input.GetKey(KeyCode.LeftShift)){
            
        }
        else if(Input.GetKey(KeyCode.A)){

        }
        else if(Input.GetKey(KeyCode.D)){

        }
    }
}
