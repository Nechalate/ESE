using UnityEngine;

public class BatteryOn : MonoBehaviour
{
    [SerializeField] GameObject controller;
    [SerializeField] Material _batteryMat;
    [SerializeField] AudioClip _powerOnSound;
    [SerializeField] GameObject _pointLight;
    LightIsOn _light;
    AudioSource _audio;
    MeshRenderer _mesh;
    Light _lightRender;
    

    void Awake() {
        _light = controller.GetComponent<LightIsOn>();
        _mesh = GetComponent<MeshRenderer>();
        _audio = GetComponent<AudioSource>();
        _lightRender = _pointLight.GetComponent<Light>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            if (_light.BatteryTake) {
                _light.BatteryIsOn = true;
                _mesh.material = _batteryMat;
                _lightRender.color = Color.green;
                if (!_audio.isPlaying) _audio.PlayOneShot(_powerOnSound);
                Destroy(GameObject.Find("BrokTip"));
            }
        }
    }
}
