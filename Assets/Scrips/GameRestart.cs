using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{
    public void RestartGame()
    {
        // โหลด Scene ปัจจุบันอีกครั้ง
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
