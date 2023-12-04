using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayStageStar : MonoBehaviour
{
    [SerializeField] Color uncollectedColor;

    [SerializeField] List<Image> stage1Star;
    [SerializeField] List<Image> stage2Star;
    [SerializeField] List<Image> stage3Star;

    private void Start()
    {
        StarInitialize();
        DisplayAllStars();
    }

    private void StarInitialize()
    {
        for (int i = 0; i < 3; i++)
        {
            stage1Star[i].color = uncollectedColor;
            stage2Star[i].color = uncollectedColor;
            stage3Star[i].color = uncollectedColor;
        }
    }

    private void DisplayAllStars()
    {
        int stage1StarN = OutgameManager.instance.GetStageStarNum(1);
        int stage2StarN = OutgameManager.instance.GetStageStarNum(2);
        int stage3StarN = OutgameManager.instance.GetStageStarNum(3);

        for(int i = 0; i < stage1StarN; i++) stage1Star[i].color = Color.white;
        for(int i = 0; i < stage2StarN; i++) stage2Star[i].color = Color.white;
        for(int i = 0; i < stage3StarN; i++) stage3Star[i].color = Color.white;
    }

    public void SetStageNumber(int n)
    {
        if (n == 1) OutgameManager.SetStage1();
        else if (n == 2) OutgameManager.SetStage2();
        else if (n == 3) OutgameManager.SetStage3();
    }
}
