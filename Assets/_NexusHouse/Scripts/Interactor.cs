using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactor : MonoBehaviour
{
    public string buttonName;
    public GameObject currentObject;
    public UnityEvent onHoverStart;
    public UnityEvent onHoverEnd;
    public UnityEvent onSelect;
    public UnityEvent onDeselect;
    public HandSource hand;
    private bool isInteracting;
    //public GameObject coffeeParent;
    //Rigidbody currentRigidbody;


    private void OnTriggerEnter(Collider other)
    {
        if (isInteracting) return;
        currentObject = other.gameObject;
        currentObject.GetComponent<Interactables>()?.onHoverStart.Invoke();
        onHoverStart.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (isInteracting) return;
        if (currentObject == other.gameObject)
        {
            currentObject.GetComponent<Interactables>()?.onHoverEnd.Invoke();
            currentObject = null;
            onHoverEnd.Invoke();
        }
    }

    private void Update()
    {
        if (Input.GetButtonDown(buttonName))
        {
            if (currentObject != null)
            {
                isInteracting = true;
                onSelect.Invoke();
                currentObject.GetComponent<Interactables>()?.onHoverEnd.Invoke();
                currentObject.GetComponent<Interactables>()?.onSelect.Invoke();
                var currentParent = transform.Find(currentObject.name);
                currentObject.transform.parent = currentParent.transform;
                currentObject.transform.localPosition = Vector3.zero;
                currentObject.transform.localRotation = Quaternion.identity;

                var rigidBody = currentObject.GetComponent<Rigidbody>();
                if (rigidBody != null)
                {
                    rigidBody.useGravity = false;
                    rigidBody.isKinematic = true;
                }
            }
        }

        if (Input.GetButtonUp(buttonName))
        {
            if (currentObject != null)
            {
                currentObject.GetComponent<Interactables>()?.onDeselect.Invoke();
                currentObject.GetComponent<Interactables>()?.onHoverStart.Invoke();
                isInteracting = false;
                onDeselect.Invoke();

                var rigidBody = currentObject.GetComponent<Rigidbody>();
                if (rigidBody != null)
                {
                    rigidBody.useGravity = true;
                    rigidBody.isKinematic = false;
                }

                currentObject.transform.parent = null;
            }
        }
    }

}

