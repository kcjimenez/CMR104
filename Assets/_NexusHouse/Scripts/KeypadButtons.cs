using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class KeypadButtons : MonoBehaviour
{
    public UnityEvent onKeyPress;
    public UnityEvent onKeyRelease;
    public GameObject button;
    private Vector3 initialButtonPosition;
    private float pressDistance = 0.003f;

    // Start is called before the first frame update
    void Start()
    {
        initialButtonPosition = button.transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        onKeyPress.Invoke();
        Vector3 newButtonPosition = initialButtonPosition - Vector3.up * pressDistance;
        button.transform.localPosition = newButtonPosition;
    }

    private void OnTriggerExit(Collider other)
    {
        onKeyRelease.Invoke();
        Vector3 newButtonPosition = initialButtonPosition + Vector3.up * pressDistance;
        button.transform.localPosition = newButtonPosition;
    }
}

