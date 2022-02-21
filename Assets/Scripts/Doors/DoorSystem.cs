using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    [SerializeField] AudioClip doorSound;
    [SerializeField] Animator animator;
    AudioSource audioSource;
    
    
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        animator.Play("Idle");
    }
    
    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player") {
            if (other.GetComponent<KeyControl>().KeyHas == true) {
                OpenDoor();
            }
        }
    }

    void OpenDoor() {
        animator.Play("DoorOpenLevel1");
        audioSource.PlayOneShot(doorSound);
    }
}
