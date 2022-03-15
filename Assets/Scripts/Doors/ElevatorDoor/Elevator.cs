using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField] Animator _elevator;
    [SerializeField] GameObject _buttonObj;
    ElevetorButton _elevBut;
    Animator _anim;
    void Awake() {
        _anim = _elevator.GetComponent<Animator>();
        _elevBut = _buttonObj.GetComponent<ElevetorButton>();
    }

    void Start() {
        _anim.Play("ElevatorIdleState");
    }

    void Update() {
        ElevatorDoorClose();
    }

    void ElevatorDoorClose() {
        if (_elevBut._buttonActivate) {
            _anim.Play("ElevatorClosed");
        } 
    }
}
