using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class TeleportLocomotion : MonoBehaviour
{
    public TeleportationArea teleportArea;
    public XRRayInteractor teleportRay;
    public InputHelpers.Button teleportButton = InputHelpers.Button.PrimaryAxis2DClick;
    public XRController controller;

    void Update()
    {
        bool isPressed;
        InputHelpers.IsPressed(controller.inputDevice, teleportButton, out isPressed);

        teleportRay.gameObject.SetActive(isPressed);
    }
}
