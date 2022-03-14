using UnityEngine;
using UnityEngine.UI;

public class UIKeycard : MonoBehaviour
{
    [SerializeField] GameObject controller;
    [SerializeField] Text MyText;
    KeyControl _cardLevel;

    void Awake() {
        _cardLevel = controller.GetComponent<KeyControl>();
        MyText = GetComponent<Text>();
    }
    
    void Update() {
        KeyLevel();
    }

    void KeyLevel() {
        if(_cardLevel.CardLevel1) {
            MyText.text = "1";
        }
    }
}
