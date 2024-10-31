using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{

    /*public void RestartGame()
    {
        // ��Ŵ Scene �Ѩ�غѹ�ա����
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/


    //New


    public Timer timer; 

    public void RestartGame()
    {
        // ��Ŵ Scene 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // ��������
        Time.timeScale = 1; 
        if (timer != null)
        {
            timer.isGameOver = false; // ��ʶҹ�����
            timer.remainingTime = 60; // ��˹����������������
            if (timer.gameOverUI != null)
            {
                timer.gameOverUI.SetActive(false); // ��͹ UI ����
            }
        }
    }

}
