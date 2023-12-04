using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] Barrier pairBarrier;
    [SerializeField] bool isSkyBlue;
    [SerializeField] bool isBarrier;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<BluePlayer>() && isSkyBlue)//플레이어가 하늘색인데, 버튼이 하늘색일때
        {
            if (isBarrier)
                pairBarrier.Disable();
            else
                pairBarrier.Enable();
        }
        else if (collision.GetComponent<GreenPlayer>() && !isSkyBlue)//플레이어가 연두색인데, 버튼이 연두색일때
        {
            if (isBarrier)
                pairBarrier.Disable();
            else
                pairBarrier.Enable();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<BluePlayer>() && isSkyBlue)//플레이어가 하늘색인데, 버튼이 하늘색일때
        {
            if (isBarrier)
                pairBarrier.Enable();
            else
                pairBarrier.Disable();
        }
        else if (collision.GetComponent<GreenPlayer>() && !isSkyBlue)//플레이어가 연두색인데, 버튼이 연두색일때
        {
            if (isBarrier)
                pairBarrier.Enable();
            else
                pairBarrier.Disable();
        }
    }
}
