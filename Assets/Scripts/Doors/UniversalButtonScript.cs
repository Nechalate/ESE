using UnityEngine;
using UnityEngine.UI;

public class UniversalButtonScript : MonoBehaviour
{
    public GameObject door;
    public GameObject cross_ON;
    UniversalDoorScript door_script;
    Text _cross_color;

    void Start() {
        door_script = door.GetComponent<UniversalDoorScript>();
        _cross_color = cross_ON.GetComponent<Text>();
    }

    void OnMouseEnter() {
        if (gameObject.tag == "Button") {
            _cross_color.color = Color.white;
        }
    }

    void OnMouseExit() {
        if (gameObject.tag == "Button") {
            _cross_color.color = Color.gray;
        } 
    }

    void OnMouseDown() {
        if (gameObject.tag == "Button" && (Vector3.Distance(transform.position, door_script._player.position) <= 3f)) { 
            door_script.Open_close();
        }
    }
}
