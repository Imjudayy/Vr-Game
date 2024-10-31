using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] GameObject gameOverUI;
    [SerializeField] float remainingTime;
    private bool isGameOver = false;
    public bool isPlayerWin = false; // สถานะชัยชนะของผู้เล่น

    private void Start()
    {
        if (gameOverUI != null)
            gameOverUI.SetActive(false);
    }

    private void Update()
    {
        if (isGameOver || isPlayerWin) return; // ถ้าเกมจบหรือผู้เล่นชนะ จะไม่อัปเดตเวลาอีก

        if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }
        else
        {
            remainingTime = 0;
            timerText.color = Color.red;

            if (gameOverUI != null)
                gameOverUI.SetActive(true);

            Time.timeScale = 0; // หยุดเกมทั้งหมด
            isGameOver = true; // บอกว่าเกมจบแล้ว
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

   
}