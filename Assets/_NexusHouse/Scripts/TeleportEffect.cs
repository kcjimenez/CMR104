using UnityEngine;

public class TeleportEffect : MonoBehaviour
{
    public ParticleSystem teleportParticles;
    public AudioSource teleportAudioSource; 
    public AudioClip teleportAudioClip1; 
    public AudioClip teleportAudioClip2; 
    public Light flashingLight; 
    public float flashDuration = 0.5f; 
    public float flashInterval = 0.7f; 

    private bool hasPlayedSecondClip = false; 
    private float nextFlashTime = 0f; 
    private bool isLightOn = false; 

    void Start()
    {
        teleportAudioSource.clip = teleportAudioClip1;
        teleportParticles.Play();
        teleportAudioSource.Play();

        flashingLight.intensity = 1f; 
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

            flashingLight.intensity = 0f; 
            Destroy(flashingLight);
            this.enabled = false; // Disable this script
        }

        // Handle the flashing light
        if (Time.time > nextFlashTime)
        {
            isLightOn = !isLightOn;

            if (isLightOn)
            {
                flashingLight.intensity = 27f;
                nextFlashTime = Time.time + flashDuration;
            }
            else
            {
                flashingLight.intensity = 10f;
                nextFlashTime = Time.time + flashInterval;
            }
        }
    }
}
