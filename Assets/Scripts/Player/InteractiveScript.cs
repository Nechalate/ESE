using UnityEngine;

public class InteractiveScript : MonoBehaviour
{
    public bool _interact = false;
    bool cheked = false;
    public bool openDoorReverse;
    void FixedUpdate()
    {
        Interact();
    }

    void Interact() {
            if (Input.GetKey(KeyCode.E)) {
            _interact = true;
            if (openDoorReverse) openDoorReverse = false;
            else openDoorReverse = true;
            Invoke("InteractReturn", 0.1f);
            } 
    }

    void InteractReturn() {
        _interact = false;
    }
}
