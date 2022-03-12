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
        if (!cheked) {
            if (Input.GetKeyDown(KeyCode.E)) {
            _interact = true;
            cheked = true;
            } 
        }
        Invoke("InteractReturn", 0.5f);
    }

    void InteractReturn() {
        _interact = false;
        cheked = false;;
    }
}
