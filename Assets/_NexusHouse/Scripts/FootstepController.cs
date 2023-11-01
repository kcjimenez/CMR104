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




/*using UnityEngine;

public class FootstepController : MonoBehaviour
{
    public AudioSource footstepAudioSource;
    public AudioClip[] footstepSounds;

    private Vector3 lastPosition;
    private float minDistanceForFootstep = 1.0f;
    private float distanceTraveled = 0.0f;

    void Start()
    {
        lastPosition = transform.position;
    }

    void Update()
    {
        Vector3 currentPosition = transform.position;
        distanceTraveled += Vector3.Distance(currentPosition, lastPosition);
        lastPosition = currentPosition;

        if (distanceTraveled >= minDistanceForFootstep)
        {
            PlayFootstepSound();
            distanceTraveled = 0.0f;
        }
    }

    void PlayFootstepSound()
    {
        if (footstepSounds.Length > 0)
        {
            int randomIndex = Random.Range(0, footstepSounds.Length);
            footstepAudioSource.clip = footstepSounds[randomIndex];
            footstepAudioSource.Play();
        }
    }
}
*/

