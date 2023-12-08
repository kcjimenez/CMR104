using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomEventListener : MonoBehaviour
{
    public UnityEvent onEventCalled;
    public CustomEvent customEvent;

    private void OnEnable()
    {
        customEvent.onCustomEventCalled.AddListener(Notify);
    }

    private void OnDisable()
    {
        customEvent.onCustomEventCalled.RemoveListener(Notify);
    }

    public void Notify()
    {
        onEventCalled.Invoke();
    }
}
