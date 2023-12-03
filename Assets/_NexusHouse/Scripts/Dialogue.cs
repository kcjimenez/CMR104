using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class Dialogue : MonoBehaviour
{
    [SerializeField] private UnityEvent onColliderTriggered;
    [SerializeField] private UnityEvent afterDialogue;
    [SerializeField] int waitTime;

    private async void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onColliderTriggered.Invoke();
            await Task.Delay(waitTime * 1000);
            afterDialogue.Invoke();
        }
    }

}
