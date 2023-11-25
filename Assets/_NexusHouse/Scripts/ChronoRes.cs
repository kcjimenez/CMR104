using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class ChronoRes : MonoBehaviour
{
    [SerializeField] private UnityEvent onVideoStart;
    [SerializeField] private UnityEvent onVideoEnd;
    [SerializeField] int videoDuration;

    public async void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("RightIndex"))
        {
            onVideoStart.Invoke();
            await Task.Delay(videoDuration * 1000);
            onVideoEnd.Invoke();
        }
    }

}
