using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    [SerializeField] GameObject gameOverUI;
    [SerializeField] float remainingTime;
    private bool isGameOver = false;

    private void Start()
    {
        if (gameOverUI != null)
            gameOverUI.SetActive(false);
    }

    private void Update()
    {
        if (isGameOver) return; // ถ้าเกมจบแล้วจะไม่อัปเดตเวลาอีก

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

    // ใช้ฟังก์ชันนี้เพื่อเริ่มใหม่หรือรีเซ็ตเกมได้
    public void RestartGame()
    {
        Time.timeScale = 1; // คืนค่าเวลาปกติ
        isGameOver = false; // รีเซ็ตสถานะเกม
        remainingTime = 60; // หรือกำหนดเวลาเริ่มต้นใหม่
        if (gameOverUI != null)
            gameOverUI.SetActive(false); // ซ่อน UI เกมจบ
    }
}
