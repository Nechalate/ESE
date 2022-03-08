using UnityEngine;

public class GatesSoundWorked : MonoBehaviour
{
    [SerializeField] AudioClip _gatesOpen;
    [SerializeField] GameObject controller;
    AudioSource _audio;
    LightIsOn _light;
    bool isCheck = false;

    void Awake() {
        _light = controller.GetComponent<LightIsOn>();
        _audio = GetComponent<AudioSource>();
    }

    void Update()
    {
        SoundOn();
    }

    void SoundOn() {
        if (_light.LightWorking && !isCheck) {
            if (!_audio.isPlaying) _audio.PlayOneShot(_gatesOpen);
            isCheck = true;
        }
    }
}
