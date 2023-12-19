using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class FlashlightTrigger : MonoBehaviour
{
    [SerializeField] Light flashlight;
    [SerializeField] AudioSource flashlightClick;
    public bool lightOn;

    void Start()
    {
        flashlight.enabled = false;
        lightOn = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.JoystickButton0) && !lightOn)
        {
            flashlight.enabled = true;
            flashlightClick.Play();
            lightOn = true;
        }

        else if (Input.GetKeyDown(KeyCode.JoystickButton0) && lightOn)
        {
            flashlight.enabled = false;
            flashlightClick.Play();
            lightOn = false;
        }
    }

    /*private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player" && !lightOn)
        {
            flashlight.enabled=true;
            lightOn= true;
        }

        else if (other.gameObject.tag == "Player" && lightOn)
        {
            flashlight.enabled = false;
            lightOn = false;
        }
    }*/
}
