using System.Collections;
using System.Collections.Generic;
using JetBrains.Rider.Unity.Editor;
using UnityEditor;
using UnityEngine;

public class player1 : MonoBehaviour
{

    public float speed_x;
    public Rigidbody2D rig;
    public bool jumped = true;
    public Collision c;

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

    private void move()
    {
        if(Input.GetKeyDown(KeyCode.LeftShift)){
            
            if(rig.velocity.y < 0.01 && rig.velocity.y > -0.01) {
                float grav = rig.gravityScale;
                rig.gravityScale = -rig.gravityScale;
            }
        }
        else if(Input.GetKey(KeyCode.A)){
            if(speed_x > 0) speed_x = 0;
            else if(speed_x >= -5) speed_x -= (float)0.01;
        }
        else if(Input.GetKey(KeyCode.D)){
            if(speed_x < 0) speed_x = 0;
            if(speed_x <= 5) speed_x += (float)0.01;
        }
        else{
            speed_x = 0;
        }

        rig.velocity = new Vector2(speed_x, rig.velocity.y);
    }
}
