using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreIncrement : MonoBehaviour
{
    public int score;
    private void OnEnable()
    {
        score = Random.Range(50, 100);
        PlayerPrefs.SetInt("score", PlayerPrefs.GetInt("score", 0) + score);
    }
}
