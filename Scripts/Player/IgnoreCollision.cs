using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class IgnoreCollision : MonoBehaviour //Make player doesn't make collision each other. 
{
    void OnCollisionEnter2D(Collision2D colli){
        if(colli.gameObject.CompareTag("Player")){
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), colli.gameObject.GetComponent<Collider2D>());
        }
    }
    
}
