using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class OneTimeCalled : MonoBehaviour
{
    public UnityEvent onCalled;
    public UnityEvent onFinished;
    public UnityEvent onSecondWait;
    bool hasBeenCalled = false;
    public int waitTime;
    public int waitTime2;

    public async void CallOnce()
    {
        if(!hasBeenCalled)
        {
            onCalled.Invoke();
            hasBeenCalled = true;
            await Task.Delay(waitTime * 1000);
            onFinished.Invoke();
            await Task.Delay(waitTime2 * 1000);
            onSecondWait.Invoke();
        }
    }
}
