using UnityEngine;

public class RadioTrigger : MonoBehaviour
{
    public AudioSource radioAudioSource;

    private bool hasTriggered = false;  // A flag to check if the trigger has been activated before

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)  // Check if it's the player and if the trigger hasn't been activated before
        {
            radioAudioSource.Play();
            hasTriggered = true;  // Set the flag to true, so it won't activate again
        }
    }
}
