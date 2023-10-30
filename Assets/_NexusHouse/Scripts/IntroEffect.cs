using UnityEngine;

public class IntroEffect : MonoBehaviour
{
    public AudioSource teleportSound;

    void Start()
    {
        // Play sound effect
        teleportSound.Play();
    }
}
