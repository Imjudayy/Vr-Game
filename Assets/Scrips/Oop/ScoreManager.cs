using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public abstract class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int amount;
    public int score;

    protected virtual void Start()
    {
        score = 0;
    }

    protected virtual void Update()
    {
        scoreText.text = $"{score} / {amount}";
    }

    public void IncreaseScore()
    {
        score += 1;
    }

    public bool HasReachedGoal()
    {
        return score >= amount;
    }
}
