using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour
{
    [SerializeField] bool isSkyBlue; 
    [SerializeField] float rotationSpeed;

    public void OnTriggerEnter2D(Collider2D Collision)
    {
        if (Collision.GetComponent<BluePlayer>() && isSkyBlue)
        {
            gameObject.SetActive(false);
            GameManager.blueGemScore++;
            Debug.Log("Blue Gem Score: " + GameManager.blueGemScore);
        }

        else if (Collision.GetComponent<GreenPlayer>() && !isSkyBlue)
        {
            gameObject.SetActive(false);
            GameManager.greenGemScore++;
            Debug.Log("Green Gem Score: " + GameManager.greenGemScore);
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
        Rotate();
    }
    void Rotate()
    {
        float currentRotation = transform.eulerAngles.y;
        float newRotation = currentRotation + rotationSpeed * Time.deltaTime;

        transform.rotation = Quaternion.Euler(0f, newRotation, 0f);
    }
}
