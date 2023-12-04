using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int MAX_GREEN_GEM_SCORE;    // the total number of existing gems
    public int MAX_BLUE_GEM_SCORE;    // the total number of existing gems
    public int MAX_KEY_SCORE;    // the total number of existing keys
    public float TIME_LIMIT;    // the time limit of this game

    float elapsedTime;   // time elapsed from start time
    static int finalScore;  // the final score of this game.

    public static int keyScore;    // the number of keys collected by characters
    public static int greenGemScore;    // the number of green gems collected by green character
    public static int blueGemScore;    // the number of blue gems collected by blue character
    
    /* so that each element below does not modify the finalScore per frame */
    bool isTimeChecked;
    bool isGreenGemChecked;
    bool isBlueGemChecked;

    public static bool isDoorOpened;   // if all the keys are collected, the final door will be opened.

    [SerializeField] Timer timer;

    // Start is called before the first frame update
    void Start()
    {        
        elapsedTime = 0.0f;

        /*
        finalScore starts at 1, (MIN: 0, MAX: 3)
        exceeding time limit, cut 1 point
        collecting all the green gems, add 1 point
        collecting all the blue gems, add 1 point
        */
        finalScore = 1;

        keyScore = 0;
        greenGemScore = 0;
        blueGemScore = 0;

        isTimeChecked = false;
        isGreenGemChecked = false;
        isBlueGemChecked = false;
        
        isDoorOpened = false;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        timer.TimeUpdate(TIME_LIMIT - elapsedTime);

        if((elapsedTime > TIME_LIMIT) && (isTimeChecked == false)) {
            finalScore--;
            isTimeChecked = true;
            Debug.Log("The time limit has been exceeded. Final Score: " + finalScore);
        }
        if((greenGemScore == MAX_GREEN_GEM_SCORE) && (isGreenGemChecked == false)) {
            finalScore++;
            isGreenGemChecked = true;
            Debug.Log("All the green gems are collected. Final Score: " + finalScore);
        }
        if((blueGemScore == MAX_BLUE_GEM_SCORE) && (isBlueGemChecked == false)) {
            finalScore++;
            isBlueGemChecked = true;
            Debug.Log("All the blue gems are collected. Final Score: " + finalScore);
        }
        if(keyScore == MAX_KEY_SCORE) {
            isDoorOpened = true;
        }
    }

    public static int GetFinalScore()
    {
        return finalScore;
    }
}
