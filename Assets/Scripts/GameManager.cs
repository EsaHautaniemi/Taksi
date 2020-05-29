using UnityEngine;

public class GameManager : MonoBehaviour
{
    private void Start()
    {
        JobManager.GenerateNewJob();
    }

    public static void QuitGame()
    {
        Application.Quit();
    }
}
