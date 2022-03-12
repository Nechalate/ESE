using UnityEngine;

public class InteractiveScript : MonoBehaviour
{
    public bool _interact = false;
    bool cheked = false;
    void FixedUpdate()
    {
        Interact();
    }

    void Interact() {
            if (Input.GetKey(KeyCode.E)) {
            _interact = true;
            Invoke("InteractReturn", 0.3f);
            } 
    }

    void InteractReturn() {
        _interact = false;
    }
}
