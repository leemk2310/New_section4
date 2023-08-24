using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreBoard : MonoBehaviour
{
    int score;
    TMP_Text scoreText;
     void Start()
    {
        scoreText = GetComponent<TMP_Text>();
        scoreText.text = "Start";
    }


    public void IncreaseScore(int amountIncreaseScore)
    {
        score = score + amountIncreaseScore;

       // Debug.Log($"Score is now :{score}");
        scoreText.text = score.ToString();
    }

}