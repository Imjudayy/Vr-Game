using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScoreManager : ScoreManager
{
    public GameObject restartPanel;
    public Timer timer;
    public CockroachScoreManager cockroachScoreManager;



    protected override void Start()
    {
        base.Start();
        amount = 12; 
    }

    protected override void Update()
    {
        base.Update();

        if (HasReachedGoal() && cockroachScoreManager.HasReachedGoal())
        {
            restartPanel.SetActive(true);
            timer.isPlayerWin = true;
            scoreText.color = Color.green;
        }
        else if (HasReachedGoal())
        {
            scoreText.color = Color.green;
        }
    }
}
