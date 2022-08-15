using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreGeral : MonoBehaviour
{
    public Text scoreText;
    public int score;

    public static ScoreGeral instance;


    void Start()
    {
        instance = this;
    }

    public void UpdateScoreText()
    {
        score++;
        scoreText.text = score.ToString();
    }
}
