using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockroachScoreManager : ScoreManager
{
    protected override void Update()
    {
        base.Update();
        if (HasReachedGoal())
        {
            scoreText.color = Color.green;
        }
    }
}