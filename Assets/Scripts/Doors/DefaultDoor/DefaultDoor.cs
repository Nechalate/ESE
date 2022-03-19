using UnityEngine;

public class DefaultDoor : MonoBehaviour
{
    [SerializeField] GameObject _doorButton;
    [SerializeField] GameObject _player;
    [SerializeField] GameObject _secondDoor;
    [SerializeField] float step = 0.05f;
    public float doorSpeed = 1f;
    [SerializeField] public bool checkCompleted;
    private float progress;
    private float _progress;
    DoorSystemButton _button;
    InteractiveScript _interact;
    Transform _secDoor;

    void Awake() {
        _button = _doorButton.GetComponent<DoorSystemButton>();
        _interact = _player.GetComponent<InteractiveScript>();
        _secDoor = _secondDoor.GetComponent<Transform>();
    }

    void Update()
    {
        DoorOpen();
    }

    // -2.1f
    void DoorOpen() {
        if (_button.doorOpened) {
            if (_interact._interact && !_interact.openDoorReverse) {
                if (transform.localPosition.x <= 2.1f) {
                    transform.localPosition = new Vector3(progress, transform.localPosition.y, transform.localPosition.z) * doorSpeed;
                    progress += step;
                }
                if (_secDoor.transform.localPosition.x >= -2.1f) {
                    _secDoor.transform.localPosition = new Vector3(_progress, transform.localPosition.y, -0.2f) * doorSpeed;
                    _progress -= step;
                }
            }
            else if (_interact._interact && _interact.openDoorReverse) {
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

