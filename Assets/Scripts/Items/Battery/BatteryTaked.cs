using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryTaked : MonoBehaviour
{
    [SerializeField] GameObject controller;
    [SerializeField] AudioClip _pickup;
    AudioSource _audio;
    LightIsOn _light;
    void Awake() {
        _light = controller.GetComponent<LightIsOn>();
        _audio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
             if (!_audio.isPlaying) _audio.PlayOneShot(_pickup);
             Invoke("BatteryPickup", 1);
        }
    }

    void BatteryPickup() {
        _light.BatteryTake = true;
        Destroy(gameObject);
    }
}
