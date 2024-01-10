using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prism : MonoBehaviour
{
    public Transform grabbedParent;
    public Transform animatedParent;
    public bool prismInTrigger;
    public Rigidbody rb;

    public void MoveToGrabbedParent()
    {
        transform.SetParent(grabbedParent);
    }


    public void PutBack()
    {
        if(prismInTrigger)
        {
            transform.SetParent(animatedParent);
            rb.useGravity = false;
            rb.isKinematic = true;
        }

        else if (!prismInTrigger)
        {
            transform.SetParent(grabbedParent);
            rb.useGravity = true;
            rb.isKinematic = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("prismTrigger"))
        {
            prismInTrigger= true;
        }

        else
        {
            prismInTrigger= false;
        }
    }
}
