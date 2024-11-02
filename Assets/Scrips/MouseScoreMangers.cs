using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MouseScoreMangers : MonoBehaviour
{
    #region Old Code
    /* public TextMeshProUGUI MouseScoreText;
     public GameObject restartPanel;

     public int amount;
     public int score;
     public Timer timer;

     // Start is called before the first frame update
     void Start()
     {
         score = 0;
         amount = 5;
         restartPanel.SetActive(false);
     }

     // Update is called once per frame
     void Update()
     {
         MouseScoreText.text = $"{score} / {amount}";

         if (score >= amount)
         {
             restartPanel.SetActive(true);
             timer.isPlayerWin = true;
         }
     }*/
    #endregion


    //new
    public TextMeshProUGUI MouseScoreText;
    public GameObject restartPanel;

    public int amount;
    public int score;
    public Timer timer;

    // อ้างอิง CockroachSocreManager
    public CockroachSocreManager cockroachScoreManager;

    void Start()
    {
        score = 0;
        amount = 5;
        restartPanel.SetActive(false);
    }

    void Update()
    {
        MouseScoreText.text = $"{score} / {amount}";

        // ตรวจสอบว่าคะแนนของ Mouse และ Cockroach ถึงเป้าหมายแล้วหรือไม่
        if (score >= amount && cockroachScoreManager != null && cockroachScoreManager.score >= cockroachScoreManager.amount)
        {
            restartPanel.SetActive(true);
            timer.isPlayerWin = true;
            MouseScoreText.color = Color.green;
        }
        else if (score >= amount)
        {
            MouseScoreText.color = Color.green; 
        }

    }
}
