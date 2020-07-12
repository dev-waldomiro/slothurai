using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    public int score = 0;
    int lastScore = 0;
    public int combo = 0;

    TextMeshProUGUI textMeshPro;

    private void Start() 
    {
        textMeshPro = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        textMeshPro.text = "Score: " + score.ToString();
    }

    public int ScoreMaker (int suggestionType, int firstBlock, int secondBlock, int playedMove) 
    {
            if(suggestionType == firstBlock || suggestionType == secondBlock)
            {
                score += 100;
            }
            else if(suggestionType == playedMove)
            {
                if(combo == 0)
                {
                    lastScore = 200;
                    score += lastScore;
                    combo++;
                } else {
                    lastScore = lastScore * 2^(combo);
                    score += lastScore;
                    combo++;
                }
            }
            else if(suggestionType != playedMove)
            {
                score += 100;
                combo = 0;
            }
        return score;
    }
}
