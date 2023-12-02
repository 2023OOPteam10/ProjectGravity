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
        if(collision.GetComponent<player1>() && isSkyBlue)//�÷��̾ �ϴû��ε�, ��ư�� �ϴû��϶�
        {
            pairBarrier.Disable();
        }
        else if (collision.GetComponent<player2>() && !isSkyBlue)//�÷��̾ ���λ��ε�, ��ư�� ���λ��϶�
        {
            pairBarrier.Disable();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<player1>() && isSkyBlue)//�÷��̾ �ϴû��ε�, ��ư�� �ϴû��϶�
        {
            pairBarrier.Enable();
        }
        else if (collision.GetComponent<player2>() && !isSkyBlue)//�÷��̾ ���λ��ε�, ��ư�� ���λ��϶�
        {
            pairBarrier.Enable();
        }
    }
}
