using UnityEngine;

public class DoorSystemButton : MonoBehaviour
{
    [SerializeField] GameObject _controller;
    InteractiveScript _interact;
    public bool doorOpened;
    
    void Awake() {
        _interact = _controller.GetComponent<InteractiveScript>();
    }

    private void OnTriggerStay(Collider other) {
        if (other.tag == "Player") {
            if (_interact._interact) doorOpened = true;
        }
    }
}
