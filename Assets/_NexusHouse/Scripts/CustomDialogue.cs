using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomDialogue : MonoBehaviour
{
    public string objectName;

    public void Notify()
    {
        var obj = GameObject.Find(objectName);
        obj.GetComponent<CustomEventSubscriber>().Notify();
        Debug.Log("custom dialogue called");
    }
}
