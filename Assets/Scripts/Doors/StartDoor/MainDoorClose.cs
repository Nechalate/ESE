using UnityEngine;

public class MainDoorClose : MonoBehaviour
{
    [SerializeField] Animator _leftDoor;
    [SerializeField] Animator _rightDoor;
    [SerializeField] AudioClip _doorClose;
    AudioSource _audio;
    
    void Start()
    {
        GetComponents();
        GatesIsClose();
    }

    void Update() {
        SpaceCutScene();
    }

    void GetComponents() {
        _audio = GetComponent<AudioSource>();
        _leftDoor = GetComponent<Animator>();
        _rightDoor = GetComponent<Animator>();
    }

    void GatesIsClose() {
        _audio.PlayOneShot(_doorClose);
        _leftDoor.Play("GatesLeft");
        _rightDoor.Play("GatesRight");
    }

    void SpaceCutScene() {
        if (!_audio.isPlaying) {
            Destroy(GameObject.Find("SpaceDust"));
            ScriptsEnabled();
        }
    }

    void ScriptsEnabled() {
            GameObject _object = GameObject.Find("FPS_Controller");
            GameObject _obj = GameObject.Find("Vision");
            PlayerMovement _movement = _object.GetComponent<PlayerMovement>();
            MouseLook _mouseLook = _obj.GetComponent<MouseLook>();
            _mouseLook.enabled = true;
            _movement.enabled = true;
    }
}
