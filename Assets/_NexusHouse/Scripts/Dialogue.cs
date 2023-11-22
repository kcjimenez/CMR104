using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Dialogue : MonoBehaviour
{
    //public AudioSource SBVoice1Source;
    //public BoxCollider SBVoice1Collider;
    [SerializeField] private UnityEvent onColliderTriggered;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onColliderTriggered.Invoke();
            /*SBVoice1Source.Play();
            Destroy(SBVoice1Collider);*/
        }
    }

}
