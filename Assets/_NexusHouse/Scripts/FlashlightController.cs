using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public Light flashlight;
    public GameObject hand;
    public GameObject head;
    public float toggleDistance = 0.5f;  // Distance from head to hand to toggle flashlight
    public float toggleCooldown = 1.0f;   // Cooldown time in seconds

    private bool isFlashlightOn = false;
    private bool handNearHead = false;     // To track if hand is near head
    private float lastToggleTime;

    void Start()
    {
        flashlight.enabled= false;
        isFlashlightOn = false;
        lastToggleTime = -toggleCooldown;  // Initialize so the flashlight can be toggled immediately
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(hand.transform.position, head.transform.position);
        bool currentlyNearHead = distance <= toggleDistance;

        // If hand state (near or not near the head) has changed and cooldown has elapsed, toggle flashlight
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
