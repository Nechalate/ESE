using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    public int loadLevel;
    public GameObject loadingScreen;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Load() {
        loadingScreen.SetActive(true);
        SceneManager.LoadScene(1);
    }
}
