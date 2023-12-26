using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private UnityEvent onColliderTriggered;
    [SerializeField] private UnityEvent afterDialogue;
    [SerializeField] private UnityEvent secondWaitTime;
    [SerializeField] int waitTime;
    [SerializeField] int waitTime2;

    private async void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onColliderTriggered.Invoke();
            await Task.Delay(waitTime * 1000);
            afterDialogue.Invoke();
            await Task.Delay(waitTime2 * 1000);
            secondWaitTime.Invoke();
        }
    }

}
