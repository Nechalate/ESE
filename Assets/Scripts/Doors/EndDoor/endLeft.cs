using UnityEngine;

public class endLeft : MonoBehaviour
{
    bool isWorking = false;
    [SerializeField] Animator _anim;
    public GameObject controller;
    private LightIsOn _lightIsOn;
    
    void Awake() {
        _lightIsOn = controller.GetComponent<LightIsOn>();
    }

    void Start() {
        _anim = GetComponent<Animator>();
        _anim.Play("leftidle");
    }

    void Update() {
        GateIsOpened();
    }

    void GateIsOpened() {
        if (!isWorking && _lightIsOn.LightWorking == true) {
            isWorking = true;
            _anim.Play("leftgatemove");
        }
    }
}
