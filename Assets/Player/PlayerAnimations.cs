using UnityEngine;

public class PlayerAnimations : MonoBehaviour
{
    public Animator _playerAnim;
    Animator _player;

    void Start() {
        _player = _playerAnim.GetComponent<Animator>();
    }

    void Update() {
        Move();
    }

    void Move() {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S)) {
            _player.SetBool("Move", true);
            if (Input.GetKey(KeyCode.LeftShift)) _player.SetBool("Run", true);
            else _player.SetBool("Run", false);
        }
        else _player.SetBool("Move", false);
    }
}
