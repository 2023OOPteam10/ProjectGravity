using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class Player_ga : MonoBehaviour
{
    private Button Button;
    private Barrier Barrier;
    private Key Key;
    private Door Door;

    private int move_method;
    public float speed;
    public Vector2 speed_vec;
    

    // Start is called before the first frame update
    void Start()
    {
        Key = GetComponent<Key>();
        move_method = 0;
        speed = 30.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if (move_method == 0)
        {
            speed_vec = Vector2.zero;

            if (Input.GetKey(KeyCode.RightArrow))
            {
                //speed_vec.x += speed;
                speed_vec.x = Input.GetAxis("Horizontal") * speed;
            }
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                //speed_vec.x -= speed;
                speed_vec.x = Input.GetAxis("Horizontal") * speed;
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                //speed_vec.y += speed;
                speed_vec.y = Input.GetAxis("Vertical") * speed;
            }
            if (Input.GetKey(KeyCode.DownArrow))
            {
                //speed_vec.y -= speed;
                speed_vec.y = Input.GetAxis("Vertical") * speed;
            }
            GetComponent<Rigidbody2D>().velocity = speed_vec;
        }
        else if(move_method == 1)
        {
            speed_vec = Vector2.zero;

            if (Input.GetKey(KeyCode.D))
            {
                //speed_vec.x += speed;
                speed_vec.x = Input.GetAxis("Horizontal") * speed;
            }
            if (Input.GetKey(KeyCode.A))
            {
                //speed_vec.x -= speed;
                speed_vec.x = Input.GetAxis("Horizontal") * speed;
            }
            if (Input.GetKey(KeyCode.W))
            {
                //speed_vec.y += speed;
                speed_vec.y = Input.GetAxis("Vertical") * speed;
            }
            if (Input.GetKey(KeyCode.S))
            {
                //speed_vec.y -= speed;
                speed_vec.y = Input.GetAxis("Vertical") * speed;
            }
            GetComponent<Rigidbody2D>().velocity = speed_vec;
        }
    }

    public void GameFailed()
    {
        Debug.Log("Game Failed.");
        Destroy(gameObject);
    }

    public void GameCompleted()
    {
        Debug.Log("Game Completed!");
        Destroy(gameObject);
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Button"))
        {
            Debug.Log("Player is on a " + collision.name);

            string number = collision.name.Replace("Button", "");
            if (GameObject.Find("Barrier" + number))
            {
                Barrier = GameObject.Find("Barrier" + number).GetComponent<Barrier>();
            }
            
            Barrier.Disable();
        }
        /*else if (collision.CompareTag("DeadZone"))
        {
            Debug.Log("Player enters a " + collision.name);

            GameFailed();
        }*/
        else if (collision.CompareTag("Key"))
        {
            Debug.Log("Player gets a key");

            Destroy(collision.gameObject);
            Key.GetKey();
        }
        else if (collision.CompareTag("Door"))
        {
            if (Key.HasAllKeys())
            {
                Debug.Log("Player has all keys.");

                GameCompleted();
            }
            else
            {
                Debug.Log("Player doesn't have all keys.");
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Button"))
        {
            string number = collision.name.Replace("Button", "");
            if (GameObject.Find("Barrier" + number))
            {
                Barrier = GameObject.Find("Barrier" + number).GetComponent<Barrier>();
            }

            Barrier.Enable();
        }
    }
}
