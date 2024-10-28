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
        if (isGameOver) return; // ����������Ǩ�����ѻവ�����ա

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

            Time.timeScale = 0; // ��ش��������
            isGameOver = true; // �͡�����������
        }

        int minutes = Mathf.FloorToInt(remainingTime / 60);
        int seconds = Mathf.FloorToInt(remainingTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    // ��ѧ��ѹ����������������������������
    public void RestartGame()
    {
        Time.timeScale = 1; // �׹������һ���
        isGameOver = false; // ����ʶҹ���
        remainingTime = 60; // ���͡�˹����������������
        if (gameOverUI != null)
            gameOverUI.SetActive(false); // ��͹ UI ����
    }
}
