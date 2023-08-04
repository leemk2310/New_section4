using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreHit : MonoBehaviour
{
   
    [SerializeField]int score = 15;

    public void IncreaseScore(int amountScore)
    {
        score = score + amountScore; // viet theo kieu basic
                                     //    score += amountScore; //viet theo kieu khac
        Debug.Log($" score is now {score}");
         
    }
}
