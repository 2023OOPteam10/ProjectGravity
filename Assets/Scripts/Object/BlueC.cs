using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueC : MonoBehaviour
{
    public Rigidbody2D rigid;
    public CircleCollider2D Col;
    public Vector2 speed;


    // Start is called before the first frame update
    void Start()
    {
        speed = Vector2.right / 150.0f;
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.position += (Vector3) speed;
    }
}
