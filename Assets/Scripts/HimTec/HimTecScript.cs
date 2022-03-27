using UnityEngine;

public class HimTecScript : MonoBehaviour
{
    [SerializeField] AudioClip _gasSound;
    AudioSource _audioSource;
    public ParticleSystem _him1;
    public ParticleSystem _him2;

    void Start() {
        _audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            _him1.Play();
            _him2.Play();
            if (!_audioSource.isPlaying) _audioSource.PlayOneShot(_gasSound);
        }
    }
}
