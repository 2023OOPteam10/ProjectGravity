using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] Barrier pairBarrier;
    [SerializeField] bool isSkyBlue;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<player1>() && isSkyBlue)//플레이어가 하늘색인데, 버튼이 하늘색일때
        {
            pairBarrier.Disable();
        }
        else if (collision.GetComponent<player2>() && !isSkyBlue)//플레이어가 연두색인데, 버튼이 연두색일때
        {
            pairBarrier.Disable();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<player1>() && isSkyBlue)//플레이어가 하늘색인데, 버튼이 하늘색일때
        {
            pairBarrier.Enable();
        }
        else if (collision.GetComponent<player2>() && !isSkyBlue)//플레이어가 연두색인데, 버튼이 연두색일때
        {
            pairBarrier.Enable();
        }
    }
}
