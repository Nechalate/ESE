using UnityEngine;

public class Transformator : MonoBehaviour
{
    AudioSource _audio;
    [SerializeField] AudioClip _transformator;

    void Awake() {
        _audio = GetComponent<AudioSource>();
    }

    void Start() {
        _audio.PlayOneShot(_transformator);
    }
    void Update()
    {
        AudioRepeat();
    }

    void AudioRepeat() {
        if (!_audio.isPlaying) _audio.PlayOneShot(_transformator);
    }
}
