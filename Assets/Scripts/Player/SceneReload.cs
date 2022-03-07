using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneReload : MonoBehaviour
{
    int sceneCount;
    void Update()
    {
        ReloadScene();
    }

    void ReloadScene() {
        if (Input.GetKey(KeyCode.Tab)) {
            sceneCount = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneCount);
        }
    }
}
