using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    [SerializeField] AudioClip _switchSound;
    [SerializeField] Animator _switchAnim;
    [SerializeField] GameObject controller;
    LightIsOn _light;
    InteractiveScript _inter;
    AudioSource _audio;
    Animator _anim;
    bool check = false;
    void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _anim = GetComponent<Animator>();
        _light = controller.GetComponent<LightIsOn>();
        _inter = controller.GetComponent<InteractiveScript>();
    }

    void Start() {
        _anim.Play("IdleSwitch");
    }

    private void OnTriggerStay(Collider other) {
        if (other.tag == "Player" && _light.BatteryIsOn && !check) {
            if (_inter._interact) {
                _light.LightWorking = true;
                check = !check;
                if (!_audio.isPlaying) _audio.PlayOneShot(_switchSound);
                _anim.Play("SwitchOn");
            }
        }
    }
}
