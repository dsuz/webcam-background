using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebCameraController : MonoBehaviour
{
    public int Width = 1920;
    public int Height = 1080;
    public int FPS = 30;
    public Material targetMaterial;

    void Start()
    {
        WebCamDevice[] devices = WebCamTexture.devices;
        // display all cameras
        for (var i = 0; i < devices.Length; i++)
        {
            Debug.Log(devices[i].name);
        }

        WebCamTexture webcamTexture = new WebCamTexture(devices[0].name, Width, Height, FPS);
        if (targetMaterial)
            targetMaterial.mainTexture = webcamTexture;
        else Debug.LogError("targetMaterial not configured");
        webcamTexture.Play();
    }
}
