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
        if(collision.GetComponent<Player_ga/*하늘색 친구 스크립트*/>() && isSkyBlue)//플레이어가 하늘색인데, 버튼이 하늘색일때
        {
            pairBarrier.Enable();
        }
        else if (collision.GetComponent<Player_ga/*연두색 친구 스크립트*/>() && !isSkyBlue)//플레이어가 연두색인데, 버튼이 연두색일때
        {
            pairBarrier.Enable();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Player_ga/*하늘색 친구 스크립트*/>() && isSkyBlue)//플레이어가 하늘색인데, 버튼이 하늘색일때
        {
            pairBarrier.Disable();
        }
        else if (collision.GetComponent<Player_ga/*연두색 친구 스크립트*/>() && !isSkyBlue)//플레이어가 연두색인데, 버튼이 연두색일때
        {
            pairBarrier.Disable();
        }
    }
}
