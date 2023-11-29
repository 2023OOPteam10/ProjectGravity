using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed;
    public Rigidbody2D rigid;
    public CircleCollider2D col;
    public GameObject fireBall;
    public float time;
    public Vector2 vec = new Vector2(1, 2);
    private void OnTriggerEnter2D(Collider2D col)
    {
        fireBall.transform.position = vec;
        vec = fireBall.transform.position;
        if(Input.GetKeyDown(KeyCode.Space) == true)
        {
            rigid.velocity += new Vector2(0, 5);
        }

        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        rigid.velocity = vec.normalized * speed;
        time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        rigid.velocity = new Vector2(0, speed) * Time.deltaTime;
    }
}
