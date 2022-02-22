using UnityEngine;

public class FanScript : MonoBehaviour
{
    [SerializeField] Animator _anim;
    void Start()
    {
        _anim = GetComponent<Animator>();
        _anim.Play("Active");
    }

}
