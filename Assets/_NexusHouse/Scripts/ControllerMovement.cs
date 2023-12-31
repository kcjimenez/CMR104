using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ControllerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float rotationAngle = 10f;
    public float rotationLerpSpeed = 1f;
    public string horizontalAxisName = "Horizontal";
    public string verticalAxisName = "Vertical";
    public string rotateAxisName = "Rotate";
    private float targetRotation;
    private float currentRotationVelocity;
    private bool justRotated;
    public GameObject mainCamera;
    CharacterController cc;


    void Awake()
    {
        cc = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        PlayerMove();
        PlayerRotate();
        //PlayerCCRotate(); 
        //print(Input.GetAxis(rotateAxisName));
    }

    void PlayerMove()
    {
        float horizontalInput = Input.GetAxis(horizontalAxisName);
        float verticalInput = -Input.GetAxis(verticalAxisName);

        Vector3 forward = mainCamera.transform.forward;
        forward.y = 0;
        forward.Normalize();
        Vector3 right = mainCamera.transform.right;
        right.y = 0;
        right.Normalize();
        Vector3 movement = horizontalInput * right - verticalInput * forward;
        
        if(!(Input.GetKey(KeyCode.JoystickButton8) || Input.GetKeyUp(KeyCode.JoystickButton8)))
        {
            cc.SimpleMove(movement * moveSpeed);
        }
        //rigidBody.velocity = movement * moveSpeed;
    }

    void PlayerRotate()
    {
        float rotationInput = Input.GetAxis(rotateAxisName);
        if(Mathf.Abs(rotationInput)>.3f)
        {
            if(justRotated == false)
            {
                float sign = Mathf.Sign(rotationInput);
                transform.Rotate(0, 30 * sign, 0);
                justRotated = true;
            }
        }
        else
        {
            justRotated = false;
        }
        //float rotationAmount = rotationInput * rotationSpeed * Time.fixedDeltaTime;
        //transform.Rotate(Vector3.up, rotationAmount);
        
    }

    void PlayerCCRotate()
    {
        transform.Rotate(0, Input.GetAxis(rotateAxisName) * rotationLerpSpeed, 0);
    }
}
