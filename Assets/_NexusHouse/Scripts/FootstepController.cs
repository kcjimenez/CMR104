using UnityEngine;

public class FootstepController : MonoBehaviour
{
    public AudioSource footstepAudioSource;
    public AudioClip footstepSound;

    void Update()
    {
        // Check if any of the arrow keys are pressed or held
        if (Mathf.Abs(Input.GetAxis("Horizontal")) > 0.1f || Mathf.Abs(Input.GetAxis("Vertical")) > 0.1f)
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
