using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    public static CameraShake cameraShake;

    public float ShakeDur;
    public float ShakeAmpli;   
    public float ShakeFreq;

    public bool startShake;

    private float ShakeElapsedTime = 0f;
    
    public CinemachineVirtualCamera VirtualCamera;
    private CinemachineBasicMultiChannelPerlin virtualCameraNoise;
    
    void Start()
    {
        cameraShake = this;
        startShake = false;
        if (VirtualCamera != null)
        {
            virtualCameraNoise = VirtualCamera.GetCinemachineComponent<Cinemachine.CinemachineBasicMultiChannelPerlin>();
        }
    }

    private void Update()
    {
        if (startShake)
        {
            StartShakeCamera();
        }
    }

    void StartShakeCamera()
    {
        if (VirtualCamera != null && virtualCameraNoise != null)
        {
            if (ShakeElapsedTime < ShakeDur)
            {
                virtualCameraNoise.m_AmplitudeGain = ShakeAmpli;
                virtualCameraNoise.m_FrequencyGain = ShakeFreq;

                ShakeElapsedTime += Time.deltaTime;
            }
            else
            {
                virtualCameraNoise.m_AmplitudeGain = 0f;
                virtualCameraNoise.m_FrequencyGain = 1f;
                ShakeElapsedTime = 0f;
                startShake = false;
            }
        }
    }
}