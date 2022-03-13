using UnityEngine.SceneManagement;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public void StartedGame() {
        LoadGame();
    }
    public void Quit() {
        Application.Quit();
    }

    void LoadGame() {
        SceneManager.LoadScene("Intro");
    }
}
