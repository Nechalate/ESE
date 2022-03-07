using UnityEngine;

public class BrokenParticles : MonoBehaviour
{
    [SerializeField] float startDelay = 5f;
    [SerializeField] float repeatDelay = 5f;
    AudioSource _audio;
    [SerializeField] AudioClip brokenSound;
    [SerializeField] ParticleSystem brokenParticle;

    void Start() {
        _audio = GetComponent<AudioSource>();
        InvokeRepeating("ParticleBoom", startDelay, repeatDelay);
    }

    void ParticleBoom() {
        if (!brokenParticle.isPlaying) {
            brokenParticle.Play();
            _audio.PlayOneShot(brokenSound);
        } 
    }
}
