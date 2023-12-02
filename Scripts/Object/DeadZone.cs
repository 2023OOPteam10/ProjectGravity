using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if (collision.GetComponent<BluePlayer>())
                collision.GetComponent<BluePlayer>().Die();
            else
                collision.GetComponent<GreenPlayer>().Die();

            Debug.Log("Die");
        }
    }
}
