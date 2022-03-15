using UnityEngine;

public class ElevetorButton : MonoBehaviour
{
    [SerializeField] Animator _animatorButton;
    [SerializeField] GameObject _controller;
    public bool _buttonActivate;
    InteractiveScript _interactive;
    Animator _anim;
    void Awake()
    {
        _anim = _animatorButton.GetComponent<Animator>();
        _interactive = _controller.GetComponent<InteractiveScript>();
    }

    void Start() {
        _anim.Play("ButtonElevatorIdle");
    }

    private void OnTriggerStay(Collider other) {
        if (other.tag == "Player") {
            if (_interactive._interact) {
                _anim.Play("ButtonElevatorPush");
                _buttonActivate = true;

            } 
        }
    }
}
