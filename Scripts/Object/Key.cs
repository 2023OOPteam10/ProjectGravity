using UnityEngine;

public class Key : MonoBehaviour 
{   
    public void OnTriggerEnter2D(Collider2D Collision)
    {
        gameObject.SetActive(false);
        GameManager.keyScore++;
        Debug.Log("Key Score: " + GameManager.keyScore);
    }
}
