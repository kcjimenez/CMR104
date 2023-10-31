using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public Light flashlight;
    public GameObject hand;
    public GameObject head;
    public float toggleDistance = 0.5f;  
    public float toggleCooldown = 1.0f;   

    private bool isFlashlightOn = false;
    private bool handNearHead = false;     // To track if hand is near head
    private float lastToggleTime;

    void Start()
    {
        flashlight.enabled= false;
        isFlashlightOn = false;
        lastToggleTime = -toggleCooldown;  // flashlight can be toggled immediately
    }

    
    void Update()
    {
        float distance = Vector3.Distance(hand.transform.position, head.transform.position);
        bool currentlyNearHead = distance <= toggleDistance;

        
        if (currentlyNearHead != handNearHead && Time.time - lastToggleTime >= toggleCooldown)
        {
            ToggleFlashlight();
            lastToggleTime = Time.time;
        }

        handNearHead = currentlyNearHead;
    }

    void ToggleFlashlight()
    {
        isFlashlightOn = !isFlashlightOn;
        flashlight.enabled = isFlashlightOn;
    }
}
