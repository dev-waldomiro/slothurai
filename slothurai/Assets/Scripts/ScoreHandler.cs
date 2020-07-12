using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHandler : MonoBehaviour
{
    public int score = 0;
    int lastScore = 0;
    public int combo = 0;

    void Update()
    {
        
    }

    public int ScoreMaker (bool enemyDefeated, int suggestionType, int firstBlock, int secondBlock, int playedMove) 
    {
        if(enemyDefeated)
        {
            if(suggestionType == firstBlock || suggestionType == secondBlock)
            {
                //give us score and dont change the combo
            }
            else if(suggestionType == playedMove)
            {
                if(combo == 0)
                {
                    //give us score, add combo and save last score
                } else {
                    //give us score (based on last score), add combo and save last score
                }
            }
            else if(suggestionType != playedMove)
            {
                //give us score and cut the combo
            }
        }
        return score;
    }
}
