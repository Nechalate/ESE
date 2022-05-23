using UnityEngine;

public class FlashLightScript : MonoBehaviour
{
    [SerializeField] Light _pointLight;
    AudioSource _audioSource; 
    [SerializeField] AudioClip flashInteract;
    void Start()
    {
        _pointLight.enabled = false;
        _audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        FlashLightControl();
    }

    void FlashLightControl() {
        if (Input.GetKeyDown(KeyCode.F)) {
            if (!_audioSource.isPlaying) _audioSource.PlayOneShot(flashInteract);
            if (!_pointLight.enabled) _pointLight.enabled = true;
            else _pointLight.enabled = false;
        } 
    }
}
