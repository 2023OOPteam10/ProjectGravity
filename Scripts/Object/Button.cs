using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] Barrier pairBarrier;
    [SerializeField] bool isSkyBlue;
    [SerializeField] bool isBarrier;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<BluePlayer>() && isSkyBlue)
        {
            if (isBarrier)
                pairBarrier.Disable();
            else
                pairBarrier.Enable();
        }
        else if (collision.GetComponent<GreenPlayer>() && !isSkyBlue)
        {
            if (isBarrier)
                pairBarrier.Disable();
            else
                pairBarrier.Enable();
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.GetComponent<BluePlayer>() && isSkyBlue)
        {
            if (isBarrier)
                pairBarrier.Enable();
            else
                pairBarrier.Disable();
        }
        else if (collision.GetComponent<GreenPlayer>() && !isSkyBlue)
        {
            if (isBarrier)
                pairBarrier.Enable();
            else
                pairBarrier.Disable();
        }
    }
}
