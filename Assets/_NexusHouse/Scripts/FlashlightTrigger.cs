using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;
using UnityEngine.Events;

public class FlashlightTrigger : MonoBehaviour
{
    [SerializeField] Light flashlight;
    [SerializeField] AudioSource flashlightClick;
    public bool lightOn;
    public bool lightGlitch;
    //[SerializeField] private UnityEvent flashlightGlitch;

    void Start()
    {
        flashlight.enabled = false;
        lightOn = false;
        lightGlitch = false;
    }

    void Update()
    {
        if (!lightGlitch)
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
    }

    public async void FlashlightGlitch()
    {
        lightGlitch = true;
        await Task.Delay(30 * 1000);
        lightGlitch = false;
        flashlight.enabled = true;
        lightOn = true;
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
