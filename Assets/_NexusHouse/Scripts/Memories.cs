using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class Memories : MonoBehaviour
{
    [SerializeField] private UnityEvent onMemoryStart;
    [SerializeField] private UnityEvent onMemoryEnd;
    [SerializeField] int memoryDuration;

    public async void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            onMemoryStart.Invoke();
            await Task.Delay(memoryDuration);
            onMemoryEnd.Invoke();
        }
    }

}
