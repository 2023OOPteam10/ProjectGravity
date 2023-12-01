using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{

    public float speed_x;
    public Rigidbody2D rig;

    // Start is called before the first frame update
    void Start()
    {
        rig = gameObject.GetComponent<Rigidbody2D>();
        speed_x = 0;
    }

    // Update is called once per frame
    void Update()
    {
        move();
    }

    void move()
    {
        if(Input.GetKeyDown(KeyCode.RightShift)){
            if(rig.velocity.y == 0) rig.velocity = rig.velocity + new Vector2(0, (float)8);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            if(speed_x > 0) speed_x = 0;
            else if(speed_x >= -5) speed_x -= (float)0.01;
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            if(speed_x < 0) speed_x = 0;
            if(speed_x <= 5) speed_x += (float)0.01;
        }
        else {
            speed_x = 0;
        }

        rig.velocity = new Vector2(speed_x, rig.velocity.y);
    }
}
