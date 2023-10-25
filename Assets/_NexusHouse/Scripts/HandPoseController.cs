using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum HandSource
{
    Left, Right
}
public class HandPoseController : MonoBehaviour
{
    public HandSource hand;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (hand == HandSource.Left)
        {
            float grip = Input.GetAxis("XRI_Left_Grip");
            GetComponent<Animator>().SetFloat("Grip", grip);
            float index = Input.GetAxis("XRI_Left_Trigger");
            GetComponent<Animator>().SetFloat("Index", index);
        }

        else
        {
            float grip = Input.GetAxis("XRI_Right_Grip");
            GetComponent<Animator>().SetFloat("Grip", grip);
            float index = Input.GetAxis("XRI_Right_Trigger");
            GetComponent<Animator>().SetFloat("Index", index);
        }
    }
}
