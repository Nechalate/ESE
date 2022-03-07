using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryOn : MonoBehaviour
{
    [SerializeField] GameObject controller;
    [SerializeField] Material _batteryMat;
    LightIsOn _light;
    MeshRenderer _mesh;
    

    void Awake() {
        _light = controller.GetComponent<LightIsOn>();
        _mesh = GetComponent<MeshRenderer>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            if (_light.BatteryTake) {
                _light.LightWorking = true;
                _mesh.material = _batteryMat;
                Destroy(GameObject.Find("BrokTip"));
            }
        }
    }
}
