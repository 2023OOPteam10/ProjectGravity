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
        if(collision.GetComponent<BluePlayer>() && isSkyBlue)//�÷��̾ �ϴû��ε�, ��ư�� �ϴû��϶�
        {
            pairBarrier.Disable();
        }
        else if (collision.GetComponent<GreenPlayer>() && !isSkyBlue)//�÷��̾ ���λ��ε�, ��ư�� ���λ��϶�
        {
            pairBarrier.Disable();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<BluePlayer>() && isSkyBlue)//�÷��̾ �ϴû��ε�, ��ư�� �ϴû��϶�
        {
            pairBarrier.Enable();
        }
        else if (collision.GetComponent<GreenPlayer>() && !isSkyBlue)//�÷��̾ ���λ��ε�, ��ư�� ���λ��϶�
        {
            pairBarrier.Enable();
        }
    }
}
