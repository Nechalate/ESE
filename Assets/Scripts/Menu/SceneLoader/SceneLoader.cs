using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] Text _loadingText;
    public float timeStart = 1;
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
                Fade();
                if (Input.anyKeyDown) asyncLoad.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    void Fade() {
        timeStart -= Time.deltaTime;
        if (timeStart > 0) {
            _loadTxt.CrossFadeAlpha(0.0f, 0.5f, false);
        } else if (timeStart <= 0) {
            _loadTxt.CrossFadeAlpha(1.0f, 0.05f, false);
        } if (timeStart <= -1) timeStart = 1;
    }
}
