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
        if(collision.GetComponent<Player_ga/*�ϴû� ģ�� ��ũ��Ʈ*/>() && isSkyBlue)//�÷��̾ �ϴû��ε�, ��ư�� �ϴû��϶�
        {
            pairBarrier.Enable();
        }
        else if (collision.GetComponent<Player_ga/*���λ� ģ�� ��ũ��Ʈ*/>() && !isSkyBlue)//�÷��̾ ���λ��ε�, ��ư�� ���λ��϶�
        {
            pairBarrier.Enable();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<Player_ga/*�ϴû� ģ�� ��ũ��Ʈ*/>() && isSkyBlue)//�÷��̾ �ϴû��ε�, ��ư�� �ϴû��϶�
        {
            pairBarrier.Disable();
        }
        else if (collision.GetComponent<Player_ga/*���λ� ģ�� ��ũ��Ʈ*/>() && !isSkyBlue)//�÷��̾ ���λ��ε�, ��ư�� ���λ��϶�
        {
            pairBarrier.Disable();
        }
    }
}
