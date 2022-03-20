using UnityEngine;

public class FlashLightScript : MonoBehaviour
{
    [SerializeField] Light _pointLight;
    void Start()
    {
        _pointLight.enabled = false;
    }

    void Update()
    {
        FlashLightControl();
    }

    void FlashLightControl() {
        if (Input.GetKeyDown(KeyCode.F)) {
            if (!_pointLight.enabled) _pointLight.enabled = true;
            else _pointLight.enabled = false;
        } 
    }
}
