using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] Text _loadingText;
    Text _loadTxt;

    public int loadLevel;
    public GameObject loadingScreen;

    void Awake()
    {
        _loadTxt = _loadingText.GetComponent<Text>();
    }

    public void Load() {
        loadingScreen.SetActive(true);
        
        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync() {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(loadLevel);

        asyncLoad.allowSceneActivation = false;

        while (!asyncLoad.isDone) {
            if (!asyncLoad.allowSceneActivation) {
                _loadTxt.text = "Press any key";
                if (Input.anyKeyDown) asyncLoad.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    void Fade() {
        _loadTxt.CrossFadeAlpha(0.0f, 0.5f, false);
        
        _loadTxt.CrossFadeAlpha(1.0f, 0.05f, false);
    }
}
