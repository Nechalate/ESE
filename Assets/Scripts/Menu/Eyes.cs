using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Eyes : MonoBehaviour
{
    Light eyesLight;
    int counter;

    void Start() {
        eyesLight = GetComponent<Light>();
    }
    void Update()
    {
         EyesBlind();
    }

    void EyesBlind() {
        counter += 1;
        if (counter >= 1000) {
            eyesLight.enabled = true;
        }
        if (counter >= 1700) {
            counter = 0;
            eyesLight.enabled = false;
        }
    }
}
