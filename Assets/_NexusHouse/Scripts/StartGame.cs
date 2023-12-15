using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;

public class StartGame : MonoBehaviour
{
    [SerializeField] private UnityEvent onButtonPress;
    [SerializeField] private UnityEvent onDelayDone;
    public int delay;
    public bool gameStarted = false;

    async void Update()
    {
        if (Input.GetKeyDown(KeyCode.Joystick1Button1) && !gameStarted)
        {
            onButtonPress.Invoke();
            gameStarted = true;
            await Task.Delay(delay * 1000);
            onDelayDone.Invoke();
        }
    }
}
