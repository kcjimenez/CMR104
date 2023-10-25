using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.OpenXR.Input;

public class TouchHapticDriver : MonoBehaviour
{
    public float amplitude;
    public HandSource hand;

    public void Vibrate(float duration)
    {
        if (hand == HandSource.Left)
        {
            var inputDevice = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
            inputDevice.SendHapticImpulse(0, amplitude, duration);
        }

        else
        {
            var inputDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
            inputDevice.SendHapticImpulse(0, amplitude, duration);
        }

    }

}
