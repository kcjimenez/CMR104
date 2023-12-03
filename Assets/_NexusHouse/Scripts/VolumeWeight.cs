using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;

public class VolumeWeight : MonoBehaviour
{
    Volume volume;
    private float timer;
    public float transition = 0.01f;
    float t = 0;

    void Start()
    {
        volume = gameObject.GetComponent<Volume>();
    }

    void Update()
    {
    }

    public void IncreaseVolumeWeight()
    {
        volume.weight = Mathf.Lerp(0f, 1f, t);
        //t += 0.5f * Time.deltaTime;
    }

    public void DecreaseVolumeWeight()
    {
        volume.weight = Mathf.Lerp(1f, 0f, t);
        //t += 0.5f * Time.deltaTime;
    }
}
