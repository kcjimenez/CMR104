using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class NumberScreen : MonoBehaviour
{
    private string numberScreen = "";

    public void NumberPress(string key)
    {
        if (numberScreen.Length < 6)
        {
            numberScreen += key;
        }
        GetComponent<TextMeshProUGUI>().text = numberScreen;

    }

    public void DeleteNumbers()
    {
        numberScreen = "";
        GetComponent<TextMeshProUGUI>().text = numberScreen;
    }

}
