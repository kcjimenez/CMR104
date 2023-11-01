using UnityEngine;

public class RadioTrigger : MonoBehaviour
{
    public AudioSource radioAudioSource;

    private bool hasTriggered = false;  // check if the trigger has been activated before

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)  
        {
            radioAudioSource.Play();
            hasTriggered = true;  
        }
    }
}
