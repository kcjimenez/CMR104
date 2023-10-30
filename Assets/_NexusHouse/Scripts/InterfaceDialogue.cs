using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceDialogue : MonoBehaviour
{
    public AudioSource interfaceOneSource;

    private bool hasTriggered = false;  // A flag to check if the trigger has been activated before

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && !hasTriggered)  // Check if it's the player and if the trigger hasn't been activated before
        {
            interfaceOneSource.Play();
            hasTriggered = true;  // Set the flag to true, so it won't activate again
        }
    }
}
