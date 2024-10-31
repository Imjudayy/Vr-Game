using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{

    /*public void RestartGame()
    {
        // โหลด Scene ปัจจุบันอีกครั้ง
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }*/


    //New


    public Timer timer; 

    public void RestartGame()
    {
        // โหลด Scene 
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

        // รีเซ็ตเวลา
        Time.timeScale = 1; 
        if (timer != null)
        {
            timer.isGameOver = false; // รีสถานะเกมจบ
            timer.remainingTime = 60; // กำหนดเวลาเริ่มต้นใหม่
            if (timer.gameOverUI != null)
            {
                timer.gameOverUI.SetActive(false); // ซ่อน UI เกมจบ
            }
        }
    }

}
