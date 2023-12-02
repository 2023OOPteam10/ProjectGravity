using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    Collider2D col;

    void OnCollisionEnter2D(Collision2D colli){
        if(colli.gameObject.CompareTag("Player")){
            Physics2D.IgnoreCollision(gameObject.GetComponent<Collider2D>(), colli.gameObject.GetComponent<Collider2D>());
        }
       
        /*if (colli.gameObject.CompareTag("Wall")) {
            Rigidbody rb = GetComponent<Rigidbody>();
            if (rb != null) {
                rb.velocity = new Vector3(0, 0, 0); 
            }
        }*/
    }
    
}
