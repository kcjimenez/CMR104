using UnityEngine;

public class FootstepController : MonoBehaviour
{
    public AudioSource footstepAudioSource;
    public AudioClip footstepSound;

    void Update()
    {
        // Check if any of the arrow keys are pressed or held
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            PlayFootstepSound();
        }
    }

    void PlayFootstepSound()
    {
        if (footstepSound != null && footstepAudioSource != null)
        {
            footstepAudioSource.clip = footstepSound;
            if (!footstepAudioSource.isPlaying)
            {
                footstepAudioSource.Play();
            }
        }
    }
}
