using UnityEngine;
using UnityEngine.XR;

public class VRInitializer : MonoBehaviour
{
    void Start()
    {
        if (!XRSettings.enabled)
        {
            Debug.LogError("VR is not enabled!");
        }
        else
        {
            Debug.Log("VR Initialized Successfully");
        }
    }
}
