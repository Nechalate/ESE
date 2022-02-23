using UnityEngine;

public class DoorSystem : MonoBehaviour
{
    [SerializeField] AudioClip doorSound;
    [SerializeField] Animator animator;
    AudioSource audioSource;
    
    bool checkOpenedDoor = true;
    
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
        if (checkOpenedDoor) {
            if (!audioSource.isPlaying) audioSource.PlayOneShot(doorSound);
            checkOpenedDoor = false;
        }
    }
}
