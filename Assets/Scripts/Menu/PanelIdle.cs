using UnityEngine;

public class PanelIdle : MonoBehaviour
{
    [SerializeField] Animator _anim;
    StartGame _start;
    void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    void Start() {
        _anim.Play("IdleMenu");
    }
}
