using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElevatorMovement : MonoBehaviour
{
    [SerializeField] Animator _animElev;
    [SerializeField] GameObject _buttonObj;
    [SerializeField] GameObject _tranSleep;
    [SerializeField] GameObject _controller;
    ElevetorButton _elevBut;
    Animator _anim;
    void Awake() {
        _anim = _animElev.GetComponent<Animator>();
        _elevBut = _buttonObj.GetComponent<ElevetorButton>();
    }

    void Start() {
        _anim.Play("ElevatorStateOnFloor");
    }

    private void OnTriggerStay(Collider other) {
        if (_elevBut._buttonActivate) {
            Invoke("ElevatorMove", 5f);
            Invoke("TranSleep", 13.5f);
        }
    }

    void ElevatorMove() {
            _anim.Play("ElevatorStateMove");
    }

    void TranSleep() {
        _tranSleep.SetActive(true);
    }
}
