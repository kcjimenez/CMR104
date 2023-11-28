using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartGame : MonoBehaviour
{
    [SerializeField] private UnityEvent onButtonPress;
    public bool gameStarted = false;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button1) && !gameStarted)
        {
            onButtonPress.Invoke();
            gameStarted = true;
        }
    }
}
