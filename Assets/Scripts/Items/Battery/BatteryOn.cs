using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryOn : MonoBehaviour
{
    [SerializeField] GameObject controller;
    [SerializeField] Material _batteryMat;
    [SerializeField] AudioClip _powerOnSound;
    LightIsOn _light;
    AudioSource _audio;
    MeshRenderer _mesh;
    

    void Awake() {
        _light = controller.GetComponent<LightIsOn>();
        _mesh = GetComponent<MeshRenderer>();
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            if (_light.BatteryTake) {
                _light.BatteryIsOn = true;
                _mesh.material = _batteryMat;
                if (!_audio.isPlaying) _audio.PlayOneShot(_powerOnSound);
                Destroy(GameObject.Find("BrokTip"));
            }
        }
    }
}
