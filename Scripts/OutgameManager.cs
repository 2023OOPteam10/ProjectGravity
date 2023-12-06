using UnityEngine;

public class OutgameManager : MonoBehaviour //manage all stages' game score information
{
    public static OutgameManager instance = null; //SingleTon Instance

    [SerializeField] int stage1Star;
    [SerializeField] int stage2Star;
    [SerializeField] int stage3Star;
    [SerializeField] static int stageNum;

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

    public static void SetStage1()
    {
        stageNum = 1;
        Debug.Log("1스테이지");
    }
    public static void SetStage2()
    {
        stageNum = 2;
        Debug.Log("2스테이지");
    }
    public static void SetStage3()
    {
        stageNum = 3;
        Debug.Log("3스테이지");
    }
}
