using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHit : MonoBehaviour
{

    int score;
    TMP_Text scoreShow;

     void Start()
    {
        scoreShow = GetComponent<TMP_Text>();
        scoreShow.text = ("Start");
    }
    public void IncreaseScore(int amountScore)
    {
        score = score + amountScore; // viet theo kieu basic
                                     //    score += amountScore; //viet theo kieu khac

        Debug.Log($" score is now {score}");
        scoreShow.text = score.ToString();
         
    }
}
