using UnityEngine;

public class Pause : MonoBehaviour //Pause game when game fail / clear / click pause button
{
    public void PauseGame()
    {
        Time.timeScale = 0;
    }

    public void ContinueGame()
    {
        Time.timeScale = 1;
    }
}
