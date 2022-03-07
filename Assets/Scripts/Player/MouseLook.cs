using UnityEngine;

public class MouseLook : MonoBehaviour
{
    [SerializeField] Transform playerBody;
    [SerializeField] float mouseSensivity = 150f; 
    float xRotation = 0f;

    void Update()
    {
        MouseRotate();
    }

    void MouseRotate() {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
