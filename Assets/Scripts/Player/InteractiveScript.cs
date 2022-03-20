using UnityEngine;
using UnityEngine.UI;

public class InteractiveScript : MonoBehaviour
{
    [SerializeField] Text _noReadyBox;
    Text _notReady;
    public bool _interact = false;
    bool cheked = false;

    void Awake() {
        _notReady = _noReadyBox.GetComponent<Text>();
    }

    void Update()
    {
        Interact();
    }

    void Interact() {
        if (!_interact) {
            if (Input.GetKeyDown(KeyCode.E)) {
                if (!_interact) {
                    _interact = true;
                    Invoke("IteractReturn", 3f);
                }
            }
        }
        else if (_interact) {
            if (Input.GetKeyDown(KeyCode.E)) {
                    _notReady.CrossFadeAlpha(1.0f, 0.05f, false);
                    _notReady.text = "NOT READY";
                    Invoke("TextFade", 2.5f);
                }  
            }
        }
    void IteractReturn() {
        _interact = false;
    }

    void TextFade() {
        _notReady.CrossFadeAlpha(0.0f, 0.5f, false);
    }
}
