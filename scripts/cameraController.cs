using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float targetVerticalFOV = 60.0f; // Your desired vertical FOV here

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        UpdateCameraFOV();
    }

    void Update()
    {
        // Check if the screen's aspect ratio changes during gameplay (e.g., when rotating the device)
        if (Screen.width != mainCamera.pixelWidth || Screen.height != mainCamera.pixelHeight)
        {
            UpdateCameraFOV();
        }
    }

    void UpdateCameraFOV()
    {
        float aspectRatio = (float)Screen.width / Screen.height;
        float newVerticalFOV = targetVerticalFOV;

        if (aspectRatio < 1.0f) // Portrait mode
        {
            newVerticalFOV *= aspectRatio;
        }

        mainCamera.fieldOfView = newVerticalFOV;
    }
}

