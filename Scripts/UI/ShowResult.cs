using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowResult : MonoBehaviour
{
    [SerializeField] Color uncollectedStarColor;
    [SerializeField] List<Image> stars;

    private void OnEnable()
    {
        StarInitialize();
        DisplayStar();
    }

    private void StarInitialize()
    {
        for(int i = 0; i < 3; i++)
            stars[i].color = uncollectedStarColor;
    }

    private void DisplayStar()
    {
        int starN = GameManager.GetFinalScore();
        for (int i = 0; i < starN; i++)
            stars[i].color = Color.white;

        OutgameManager.instance.SetStageStar(starN);
    }
}
