using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupKey : MonoBehaviour
{
    AudioSource audioSource;
    [SerializeField] AudioClip pickupItemSound;
    
    void Start() {
        audioSource = GetComponent<AudioSource>();
    }

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            if (audioSource.isPlaying != true) {
                audioSource.PlayOneShot(pickupItemSound);
            }
            Destroy(gameObject, 0.5f);
        }
    }
}
