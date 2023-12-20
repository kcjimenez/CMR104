using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class OneTimeCalled : MonoBehaviour
{
    public UnityEvent onCalled;
    public UnityEvent onFinished;
    bool hasBeenCalled = false;
    public int waitTime;

    public async void CallOnce()
    {
        if(!hasBeenCalled)
        {
            onCalled.Invoke();
            hasBeenCalled = true;
            await Task.Delay(waitTime * 1000);
            onFinished.Invoke();
        }
    }
}
