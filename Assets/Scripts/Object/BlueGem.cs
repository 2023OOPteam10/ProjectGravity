using System.Collections;
using System.Collections.Generic;
using UnityEditor.AnimatedValues;
using UnityEditor.Build.Content;
using UnityEngine;

public class BlueGem : MonoBehaviour
{   
    public Rigidbody2D rigid;
    public CircleCollider2D Col;
    public float rotationSpeed;

    public void OnTriggerEnter2D(Collider2D Collision)
    {
        if(Collision.CompareTag("Blue")) {
            gameObject.SetActive(false);
            GameManager.blueGemScore++;
            Debug.Log("Blue Gem Score: " + GameManager.blueGemScore);
        }
    }

    // Start is called before the first frame update
    void Start()
    {        
        rotationSpeed = 100.0f;
    }

    // Update is called once per frame
    void Update()
    {
        float currentRotation = transform.eulerAngles.y;
        float newRotation = currentRotation + rotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0f, newRotation, 0f);
    }
}
