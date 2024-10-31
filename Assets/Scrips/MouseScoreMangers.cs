using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MouseScoreMangers : MonoBehaviour
{
    public TextMeshProUGUI MouseScoreText;
    public GameObject restartPanel;

    public int amount;
    public int score;
    public Timer timer;  // อ้างอิงถึง Timer

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
        MouseScoreText.text = $"Mouse = {score} / {amount}";

        if (score >= amount)
        {
            restartPanel.SetActive(true);
            timer.isPlayerWin = true;  // หยุดการนับเวลาถอยหลัง
        }
    }
}
