using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] CharacterController controller;
    public Transform groundCheck;
    public LayerMask groundMask;
    [SerializeField] float moveSpeed = 10f;

    float gravity = -9.8f;
    Vector3 velocity;
    bool isGround;
    float groundDistance = 0.4f;
    void Start()
    {
        
    }

    void Update()
    {
        CharacterMove();
    }

    void CharacterMove() {

        GroundPhysics();
        VectorInput();
        Fall();
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

    void Jump() {
        
    }
}
