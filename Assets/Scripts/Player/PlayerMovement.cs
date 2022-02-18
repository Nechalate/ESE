using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    public Transform groundCheck;
    public LayerMask groundMask;
    [SerializeField] float moveSpeed = 10f;
    [SerializeField] float jumpHeight = 0.4f;
    [SerializeField] AudioClip playerFootsteps;
    AudioSource audioSource;

    float gravity = -9.8f;
    Vector3 velocity;
    bool isGround;
    float groundDistance = 0.4f;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    void Update()
    {
        CharacterMove();
    }

    void CharacterMove() {

        GroundPhysics();
        VectorInput();
        FootSound();
        Fall();
        Jumping();
    }

    void GroundPhysics() {
        isGround = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);
        if (isGround && velocity.y < 0) {
            velocity.y = -2f;
        }
    }

    void VectorInput() {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * moveSpeed * Time.deltaTime);
    }

    void Fall() {
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }

    void Jumping() {
        if (Input.GetButtonDown("Jump") && isGround) {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        }
    }

    void FootSound() {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S)) {
            if (!audioSource.isPlaying) audioSource.PlayOneShot(playerFootsteps);
        }
        else audioSource.Stop();
    }
}
