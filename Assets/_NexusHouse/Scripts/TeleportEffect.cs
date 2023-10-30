using UnityEngine;

public class TeleportEffect : MonoBehaviour
{
    public ParticleSystem teleportParticles;
    public AudioSource teleportAudioSource; // AudioSource component
    public AudioClip teleportAudioClip1; // First audio clip
    public AudioClip teleportAudioClip2; // Second audio clip
    public Light flashingLight; // Reference to the light you want to flash
    public float flashDuration = 0.5f; // Duration of each flash (on state)
    public float flashInterval = 0.7f; // Time between each flash

    private bool hasPlayedSecondClip = false; // Track if the second clip has played
    private float nextFlashTime = 0f; // Time when the next flash should happen
    private bool isLightOn = false; // Track the state of the light

    void Awake()
    {
        teleportAudioSource.clip = teleportAudioClip1;
        teleportParticles.Play();
        teleportAudioSource.Play();

        flashingLight.intensity = 1f; // Ensure light is initially on (assuming max intensity is 1)
        nextFlashTime = Time.time + flashInterval;
    }

    void Update()
    {
        if (!teleportAudioSource.isPlaying && !hasPlayedSecondClip)
        {
            teleportAudioSource.clip = teleportAudioClip2;
            teleportAudioSource.Play();
            hasPlayedSecondClip = true;
        }
        else if (!teleportAudioSource.isPlaying && hasPlayedSecondClip)
        {
            if (teleportParticles.isPlaying)
            {
                teleportParticles.Stop();
            }

            flashingLight.intensity = 0f; // Set light intensity to zero, effectively turning it off
            this.enabled = false; // Disable this script
        }

        // Handle the flashing light
        if (Time.time > nextFlashTime)
        {
            isLightOn = !isLightOn;

            if (isLightOn)
            {
                flashingLight.intensity = 350f;
                nextFlashTime = Time.time + flashDuration;
            }
            else
            {
                flashingLight.intensity = 0f;
                nextFlashTime = Time.time + flashInterval;
            }
        }
    }
}
