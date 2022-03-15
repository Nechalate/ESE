using UnityEngine.SceneManagement;
using UnityEngine;

public class TestSceneLoadTrigger : MonoBehaviour
{
    [SerializeField] GameObject _loader;
    SceneLoader _scene;

    void Start() {
        _scene = _loader.GetComponent<SceneLoader>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            _scene.Load();
        }
    }
}
