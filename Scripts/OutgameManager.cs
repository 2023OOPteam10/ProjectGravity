using UnityEngine;

public class OutgameManager : MonoBehaviour
{
    public static OutgameManager instance = null; //SingleTon Instance

    private int stage1Star;
    private int stage2Star;
    private int stage3Star;
    private int stageNum;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            if (instance != this) 
                Destroy(this.gameObject);
        }
    }

    public void SetStageStar(int starNum)
    {
        switch (stageNum)
        {
            case 1:
                if(stage1Star < starNum) stage1Star = starNum;
                break;
            case 2:
                if(stage2Star < starNum) stage2Star = starNum;
                break;
            case 3:
                if(stage3Star < starNum) stage3Star = starNum;
                break;
        }
    }

    public int GetStageStarNum(int stageNum)
    {
        int star = 0;
        switch(stageNum)
        {
            case 1: star = stage1Star;
                break;
            case 2: star = stage2Star;
                break;
            case 3: star = stage3Star;
                break;
        }
        return star;
    }

    public void SetStageNum(int n)
    {
        stageNum = n;
    }
}
