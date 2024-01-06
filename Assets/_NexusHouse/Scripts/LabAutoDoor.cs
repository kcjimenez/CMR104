using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabAutoDoor : MonoBehaviour
{
    public bool labDoorOpen = false;
    public Animator doorAnimator;

    public void SetOpen()
    {
        if(!labDoorOpen)
        {
            labDoorOpen = true;
        }
    }

    public void SetClose()
    {
        if(labDoorOpen)
        {
            labDoorOpen = false;
        }
    }

    public void MoveDoors()
    {
        if(labDoorOpen)
        {
            doorAnimator.SetTrigger("close");
        }

        else if (!labDoorOpen)
        {
            doorAnimator.SetTrigger("open");
        }
    }
}
