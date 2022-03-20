using UnityEngine;

public class DefaultDoor : MonoBehaviour
{
    [SerializeField] GameObject _doorButton;
    [SerializeField] GameObject _doorButtonTwo;
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _secondDoor;
    [SerializeField] float step = 0.05f;
    public float doorSpeed = 1f;
    private float progress;
    private float _progress;
    DoorSystemButton _button;
    DoorSystemButton _buttonTwo;
    InteractiveScript _interact;
    Transform _secDoor;
    ReverseCheckScript _doorSystemButton;
    ReverseCheckScript _doorSystemButtonTwo;
    /*ReverseCheckScript _reverse;
    ReverseCheckScript _reverseTwo;*/

    void Awake() {
        _button = _doorButton.GetComponent<DoorSystemButton>();
        _buttonTwo = _doorButtonTwo.GetComponent<DoorSystemButton>();
        _interact = _player.GetComponent<InteractiveScript>();
        _secDoor = _secondDoor.GetComponent<Transform>();
        _doorSystemButton = _doorButton.GetComponent<ReverseCheckScript>();
        _doorSystemButtonTwo = _doorButtonTwo.GetComponent<ReverseCheckScript>();
    }

    void Update()
    {
        DoorOpen();
        //ButtonCheck();
    }

/*
    void ButtonCheck() {
        if (_button.doorOpened && !_reverse.reverseCheck && _interact._interact) {
            _reverse.reverseCheck = true;
            _reverseTwo.reverseCheck = true;
        } 
        
        if (_button.doorOpened && _reverse.reverseCheck && _interact._interact) {
            _reverse.reverseCheck = false;
            _reverseTwo.reverseCheck = false;
        }
        
    }
*/
    void DoorOpen() {       
        if (_button.doorOpened || _buttonTwo.doorOpened) {
            if (_interact._interact && (_doorSystemButton.reverseCheck || _doorSystemButtonTwo.reverseCheck)) {
                if (transform.localPosition.x <= 2.1f) {
                    transform.localPosition = new Vector3(progress, transform.localPosition.y, transform.localPosition.z) * doorSpeed;
                    progress += step;
                }
                if (_secDoor.transform.localPosition.x >= -2.1f) {
                    _secDoor.transform.localPosition = new Vector3(_progress, transform.localPosition.y, -0.2f) * doorSpeed;
                    _progress -= step;
                }
            }     
            else if (_interact._interact && (!_doorSystemButton.reverseCheck || !_doorSystemButtonTwo.reverseCheck)) {
                if (transform.localPosition.x >= 0f) {
                    transform.localPosition = new Vector3(progress, transform.localPosition.y, transform.localPosition.z) * doorSpeed;
                    progress -= step;
                }
                if (_secDoor.transform.localPosition.x <= 0f) {
                    _secDoor.transform.localPosition = new Vector3(_progress, transform.localPosition.y, -0.2f) * doorSpeed;
                    _progress += step;
                }
            }
            
        }
    }
}

