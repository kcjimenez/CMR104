using UnityEngine;

public class FlashlightControl : MonoBehaviour
{
    public Light flashlight;  
    public string handTag = "VRHand";  

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.CompareTag(handTag))
        {
            flashlight.enabled = !flashlight.enabled;  
        }
    }
}
