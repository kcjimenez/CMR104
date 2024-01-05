using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class Memories : MonoBehaviour
{
    [SerializeField] private UnityEvent onMemoryStart;
    [SerializeField] private UnityEvent onMemoryEnd;
    [SerializeField] private UnityEvent onReactEnd;
    [SerializeField] int memoryDuration;
    [SerializeField] int waitTime;

    public async void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onMemoryStart.Invoke();
            await Task.Delay(memoryDuration * 1000);
            onMemoryEnd.Invoke();
            await Task.Delay(waitTime * 1000);
            onReactEnd.Invoke();
        }
    }

}
