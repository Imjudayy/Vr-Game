using UnityEngine;
using UnityEngine.SceneManagement;

public class GameRestart : MonoBehaviour
{
    public void RestartGame()
    {
        // ��Ŵ Scene �Ѩ�غѹ�ա����
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
