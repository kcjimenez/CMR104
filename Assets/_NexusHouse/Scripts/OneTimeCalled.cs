using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OneTimeCalled : MonoBehaviour
{
    public UnityEvent onCalled;
    public void CallOnce()
    {
        onCalled.Invoke();
    }
}
