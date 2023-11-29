using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
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
        if(Input.GetKey(KeyCode.RightShift)){

        }
        else if(Input.GetKey(KeyCode.LeftArrow)){

        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            
        }
    }
}
