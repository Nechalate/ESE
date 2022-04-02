using UnityEngine;

public class AmbientTrigger : MonoBehaviour
{
    [SerializeField] GameObject _ambient;

    private void OnTriggerEnter(Collider other) {
        _ambient.SetActive(true);
    }
}
