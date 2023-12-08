using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OneTimeCalled : MonoBehaviour
{
    public UnityEvent onCalled;
    bool hasBeenCalled = false;
    public void CallOnce()
    {
        if(!hasBeenCalled)
        {
            onCalled.Invoke();
            hasBeenCalled = true;
        }
    }
}
