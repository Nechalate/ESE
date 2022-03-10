using UnityEngine;

public class SwitchScript : MonoBehaviour
{
    [SerializeField] AudioClip _switchSound;
    [SerializeField] Animator _switchAnim;
    [SerializeField] GameObject controller;
    LightIsOn _light;
    AudioSource _audio;
    Animator _anim;
    bool check = false;
    void Awake()
    {
        _audio = GetComponent<AudioSource>();
        _anim = GetComponent<Animator>();
        _light = controller.GetComponent<LightIsOn>();
    }

    void Start() {
        _anim.Play("IdleSwitch");
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player" && _light.BatteryIsOn && !check) {
            _light.LightWorking = true;
            check = !check;
            if (!_audio.isPlaying) _audio.PlayOneShot(_switchSound);
            _anim.Play("SwitchOn");
        }
    }
}
