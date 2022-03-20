using UnityEngine;
using UnityEngine.UI;

public class DoorSystemButton : MonoBehaviour
{
    [SerializeField] GameObject _controller;
    [SerializeField] GameObject _reverseButton;
    [SerializeField] GameObject _reverseButtonTwo;
    [SerializeField] Text _openText;
    InteractiveScript _interact;
    ReverseCheckScript _reverse;
    ReverseCheckScript _reverseTwo;
    DoorSystemButton _reverseIteract;
    public bool doorOpened;
    public bool reverseInteract;
    Text _open;
    
    void Awake() {
        _interact = _controller.GetComponent<InteractiveScript>();
        _reverse = _reverseButton.GetComponent<ReverseCheckScript>();
        _reverseTwo = _reverseButtonTwo.GetComponent<ReverseCheckScript>();
        _reverseIteract = _reverseButtonTwo.GetComponent<DoorSystemButton>();
        _open = _openText.GetComponent<Text>();
    }

    private void OnTriggerStay(Collider other) {
        if (other.tag == "Player") {
            doorOpened = true;
            _open.text = "INTERACT";
            if (_interact._interact) {
                if ((!_reverse.reverseCheck && !_reverseTwo.reverseCheck) && !reverseInteract) {
                    _reverse.reverseCheck = true;
                    _reverseTwo.reverseCheck = true;
                    Invoke("ReverseReturnTrue", 3f);
                } 
                if ((_reverse.reverseCheck && _reverseTwo.reverseCheck) && reverseInteract) {
                    _reverse.reverseCheck = false;
                    _reverseTwo.reverseCheck = false;
                    Invoke("ReverseReturnFalse", 3f);
                }     
            }
        } 
    }


    void ReverseReturnTrue() {
        reverseInteract = true;
        _reverseIteract.reverseInteract = true;
    }

    void ReverseReturnFalse() {
        reverseInteract = false;
        _reverseIteract.reverseInteract = false;
    }

    private void OnTriggerExit(Collider other) {
        if (other.tag == "Player") Invoke("DoorReturn", 1.5f);
        _openText.text = "";
    }

    void DoorReturn() {
        doorOpened = false;
    }
}
