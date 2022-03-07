using UnityEngine;

public class CursorLock : MonoBehaviour
{
    void Start()
    {
        CursorLockState();
    }

    void CursorLockState() {
        Cursor.lockState = CursorLockMode.Locked;
    }
}
