using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CockroachSocreManager : MonoBehaviour
{
    #region Old Code
    /* public TextMeshProUGUI CockroachScoreText;
     public GameObject restartPanel;

     public int amount;
     public int score;
     public Timer timer;

     // Start is called before the first frame update
     void Start()
     {
         score = 0;
         amount = 10;
         restartPanel.SetActive(false);
     }

     // Update is called once per frame
     void Update()
     {
         CockroachScoreText.text = $"{score} / {amount}";

         if (score >= amount)
         {
             restartPanel.SetActive(true);
             timer.isPlayerWin = true;
         }
     }*/
    #endregion


    public TextMeshProUGUI CockroachScoreText;
    public int amount;
    public int score;

    void Start()
    {
        score = 0;
        amount = 1;
    }

    void Update()
    {
        CockroachScoreText.text = $"{score} / {amount}";
        if (score >= amount)
        {
            CockroachScoreText.color = Color.green ;
        }
    }

}
