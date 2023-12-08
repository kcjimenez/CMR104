using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.Rendering;

public class VolumeWeight : MonoBehaviour
{
    Volume volume;
    private float timer;
    public float transition = 2f;
    float t = 0;
    bool activated = false;
     
    void Start()
    {
        volume = gameObject.GetComponent<Volume>();
    }

    void Update()
    {
        if(activated)
        {
            t += Time.deltaTime * transition;
        }

        else
        {
            t -= Time.deltaTime * transition;
        }
        t=Mathf.Clamp(t,0,1);
        volume.weight = Mathf.Lerp(0f, 1f, t);
    }

    public void IncreaseVolumeWeight()
    {
        activated= true;
        //t += 0.5f * Time.deltaTime;
    }

    public void DecreaseVolumeWeight()
    {
        activated= false;
        //t += 0.5f * Time.deltaTime;
    }
}
