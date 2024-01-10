using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalChoice : MonoBehaviour
{
    public bool destroyChosen = false;
    public bool dontDestroyChosen = false;

    public void NextScene()
    {
        if(destroyChosen && !dontDestroyChosen)
        {
            SceneManager.LoadScene(2);
        }

        else if (!destroyChosen && dontDestroyChosen)
        {
            SceneManager.LoadScene(3);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("DestroyTrigger"))
        {
            destroyChosen = true;
            dontDestroyChosen = false;
        }

        else if (other.CompareTag("DontDestroyTrigger"))
        {
            destroyChosen = false;
            dontDestroyChosen = true;
        }
    }

}
