using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ChronoResBlinking : MonoBehaviour
{
    [SerializeField] private UnityEvent onDialogueTriggered;
    public bool Voice2Triggered = false;

    private void Update()
    {
        if (Voice2Triggered)
        {
            onDialogueTriggered.Invoke();
        }
    }
}
