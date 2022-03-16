using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorButtonOpen : MonoBehaviour
{
    [SerializeField] GameObject _doorButton;
    [SerializeField] Vector3 startPosition;
    [SerializeField] Vector3 endPosition;
    [SerializeField] float step;
    public float doorSpeed = 1;
    private float progress;

    DoorSystemButton _button;

    void Awake() {
        _button = _doorButton.GetComponent<DoorSystemButton>();
    }

    void Start() {
        transform.localPosition = startPosition;
    }

    void FixedUpdate() {
        DoorOpenAnim();
    }

    void DoorOpenAnim() {
        if (_button.doorOpened) {
            if (transform.localPosition.y <= 2.8f) {
                transform.localPosition = new Vector3(0,progress, 0) * doorSpeed;
                progress += step;
            }
            
        }
    }
}
