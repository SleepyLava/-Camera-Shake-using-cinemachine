using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerShake : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) || Input.GetKeyDown(KeyCode.Space))
        {
            CameraShake.cameraShake.startShake = true;
            CameraShake.cameraShake.ShakeDur = 0.5f;
            CameraShake.cameraShake.ShakeAmpli = 1;
            CameraShake.cameraShake.ShakeFreq = 1;
        }
    }
}
