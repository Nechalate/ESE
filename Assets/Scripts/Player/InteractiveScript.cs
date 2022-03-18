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
                if (!_interact) _interact = true;
                    else _interact = false;
                if (openDoorReverse) openDoorReverse = false;
                    else openDoorReverse = true;
            } 
    }
}
