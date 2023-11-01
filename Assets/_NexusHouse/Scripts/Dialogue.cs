using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dialogue : MonoBehaviour
{
    public AudioSource SBVoice1Source;
    public BoxCollider SBVoice1Collider;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            SBVoice1Source.Play();
            Destroy(SBVoice1Collider);
        }
    }
}
