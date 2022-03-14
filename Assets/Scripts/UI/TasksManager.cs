using UnityEngine.UI;
using UnityEngine;

public class TasksManager : MonoBehaviour
{
    [SerializeField] GameObject controller;
    [SerializeField] Text _textPick;
    Text _textKey;
    [SerializeField] Text _textBatteryTaked;
    Text _textBatTaked;
    [SerializeField] Text _textBatteryConnected;
    Text _textBatCon;
    [SerializeField] Text _gatesOpened;
    Text _gateOn;
    KeyControl _keyPickup;
    LightIsOn _light;
    void Awake()
    {
        _keyPickup = controller.GetComponent<KeyControl>();
        _light = controller.GetComponent<LightIsOn>();

        _textKey = _textPick.GetComponent<Text>();
        _textBatTaked = _textBatteryTaked.GetComponent<Text>();
        _textBatCon = _textBatteryConnected.GetComponent<Text>();
        _gateOn = _gatesOpened.GetComponent<Text>();
    }

    void Update()
    {
        KeyCheck();
        FindBattery();
        BatteryConnected();
        GatesOpened();
    }

    void KeyCheck() {
        if (_keyPickup.CardLevel1) _textKey.color = Color.green;
    }

    void FindBattery() {
        if (_light.BatteryTake) _textBatTaked.color = Color.green; 
    }

    void BatteryConnected() {
        if (_light.BatteryIsOn) _textBatCon.color = Color.green;
    }

    void GatesOpened() {
        if (_light.LightWorking) _gateOn.color = Color.green;
    }
}
