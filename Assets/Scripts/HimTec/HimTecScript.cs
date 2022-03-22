using UnityEngine;

public class HimTecScript : MonoBehaviour
{
    public ParticleSystem _him1;
    public ParticleSystem _him2;
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            _him1.Play();
            _him2.Play();
        }
    }
}
