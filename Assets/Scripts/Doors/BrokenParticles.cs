using UnityEngine;

public class BrokenParticles : MonoBehaviour
{
    [SerializeField] ParticleSystem brokenParticle;

    void Update()
    {
        Invoke("ParticleBoom", 3);
    }

    void ParticleBoom() {
        if (!brokenParticle.isPlaying) brokenParticle.Play();
    }
}
