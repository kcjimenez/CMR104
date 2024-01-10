using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class FinalChoice : MonoBehaviour
{
    public bool destroyChosen = false;
    public bool dontDestroyChosen = false;
    public UnityEvent onDestroy;
    public UnityEvent onDontDestroy;
    public Rigidbody rb;

    public void NextScene()
    {
        if(destroyChosen && !dontDestroyChosen)
        {
            onDestroy.Invoke();
        }

        else if (!destroyChosen && dontDestroyChosen)
        {
            onDontDestroy.Invoke();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DestroyTrigger"))
        {
            destroyChosen = true;
            dontDestroyChosen = false;
            rb.useGravity= false;
            rb.isKinematic= true;
        }

        else if (other.CompareTag("DontDestroyTrigger"))
        {
            destroyChosen = false;
            dontDestroyChosen = true;
            rb.useGravity = false;
            rb.isKinematic = true;
        }
    }

}
