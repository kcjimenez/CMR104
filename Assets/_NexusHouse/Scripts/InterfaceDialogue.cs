using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceDialogue : MonoBehaviour
{
    public AudioSource interfaceOneSource;
    public AudioClip interfaceOneClip;

    public void InterfaceOne()
    {
        interfaceOneSource.PlayOneShot(interfaceOneClip);
    }
}
