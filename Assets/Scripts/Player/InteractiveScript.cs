using UnityEngine;

public class InteractiveScript : MonoBehaviour
{
    public bool _interact = false;
    bool cheked = false;
    public bool openDoorReverse = true;
    void Update()
    {
        Interact();
    }

    void Interact() {
        if (!_interact) {
            if (Input.GetKeyDown(KeyCode.E)) {
                if (openDoorReverse) openDoorReverse = false;
                    else openDoorReverse = true;
                if (!_interact) {
                    _interact = true;
                    Invoke("IteractReturn", 2.5f);
                } 
            } 
        }
    }
    void IteractReturn() {
        _interact = false;
    }
}
