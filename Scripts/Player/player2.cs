using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player2 : MonoBehaviour
{
    public Vector2 dir;
    public float speed_x;
    public float jumpAmount;
    public float speedAmount;
    public float maxSpeed;
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
        dir = rig.velocity;
        move();
    }

    void move()
    {
        if(Input.GetKeyDown(KeyCode.RightShift)){
            if(rig.velocity.y < 0.01 && rig.velocity.y > -0.01) rig.velocity = rig.velocity + new Vector2(0, jumpAmount);
        }
        else if(Input.GetKey(KeyCode.LeftArrow)){
            if(speed_x > 0) speed_x = 0;
            else if(speed_x >= -maxSpeed) speed_x -= speedAmount;
        }
        else if(Input.GetKey(KeyCode.RightArrow)){
            if(speed_x < 0) speed_x = 0;
            if(speed_x <= maxSpeed) speed_x += speedAmount;
        }
        else {
            speed_x = 0;
        }

        rig.velocity = new Vector2(speed_x * Time.deltaTime, rig.velocity.y);
    }
}
