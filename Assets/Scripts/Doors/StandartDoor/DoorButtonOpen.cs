using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButtonOpen : MonoBehaviour
{
    [SerializeField] GameObject _doorButton;
    [SerializeField] GameObject _player;
    [SerializeField] float step;
    public float doorSpeed = 1;
    private float progress;
    DoorSystemButton _button;
    InteractiveScript _interact;

    void Awake() {
        _button = _doorButton.GetComponent<DoorSystemButton>();
        _interact = _player.GetComponent<InteractiveScript>();
    }

    void FixedUpdate() {
        DoorOpenAnim();
    }

    void DoorOpenAnim() {
        if (_button.doorOpened && !_interact.openDoorReverse) {
            if (transform.localPosition.y <= 2.95f) {
                transform.localPosition = new Vector3(transform.localPosition.x, progress, transform.localPosition.z) * doorSpeed;
                progress += step;
            }
        }
        else if (_button.doorOpened && _interact.openDoorReverse) {
            if (transform.localPosition.y >= 0f) {
                transform.localPosition = new Vector3(transform.localPosition.x, progress, transform.localPosition.z) * doorSpeed;
                progress -= step;
            }
        }
    }
}
