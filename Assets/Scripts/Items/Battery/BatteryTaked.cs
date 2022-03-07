using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryTaked : MonoBehaviour
{
    [SerializeField] GameObject controller;
    LightIsOn _light;
    void Awake() {
        _light = controller.GetComponent<LightIsOn>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            _light.BatteryTake = true;
            Destroy(gameObject);
        }
    }
}
