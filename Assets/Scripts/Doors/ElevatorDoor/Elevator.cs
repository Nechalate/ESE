using UnityEngine;

public class Elevator : MonoBehaviour
{
    [SerializeField] Animator _elevator;
    Animator _anim;
    void Awake() {
        _anim = GetComponent<Animator>();
    }

    void Start() {
        _anim.Play("ElevatorIdle");
    }
}
