using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu]

public class CustomEvent : ScriptableObject
{
    public UnityEvent onCustomEventCalled;

    public void CallCustomEvent()
    {
        onCustomEventCalled.Invoke();
    }
}
