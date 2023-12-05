using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CustomEventSubscriber : MonoBehaviour
{
    public UnityEvent onCalled;
    public void Notify()
    {
        onCalled.Invoke();
        Debug.Log("custom event subscriber called");
    }
}
