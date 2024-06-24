using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class VRMovement : MonoBehaviour
{
    public float speed = 1.0f;

    private CharacterController characterController;
    private InputDevice leftHandDevice;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        InitializeInputDevices();
    }

    void InitializeInputDevices()
    {
        List<InputDevice> devices = new List<InputDevice>();
        InputDevices.GetDevicesAtXRNode(XRNode.LeftHand, devices);

        if (devices.Count > 0)
        {
            leftHandDevice = devices[0];
            Debug.Log("Left hand device found: " + leftHandDevice.name);
        }
        else
        {
            Debug.LogWarning("No left hand devices found");
        }
    }

    void Update()
    {
        if (!leftHandDevice.isValid)
        {
            InitializeInputDevices();
        }

        UpdateMovement();
    }

    void UpdateMovement()
    {
        if (leftHandDevice.isValid)
        {
            Vector2 inputAxis;
            if (leftHandDevice.TryGetFeatureValue(CommonUsages.primary2DAxis, out inputAxis))
            {
                Vector3 move = new Vector3(inputAxis.x, 0, inputAxis.y);

                // Transform the movement direction relative to the camera's facing direction
                Vector3 forward = Camera.main.transform.forward;
                forward.y = 0; // Keep the direction strictly horizontal
                forward.Normalize();

                Vector3 right = Camera.main.transform.right;
                right.y = 0; // Keep the direction strictly horizontal
                right.Normalize();

                Vector3 desiredMoveDirection = forward * move.z + right * move.x;
                characterController.Move(desiredMoveDirection * speed * Time.deltaTime);
            }
        }
    }
}
