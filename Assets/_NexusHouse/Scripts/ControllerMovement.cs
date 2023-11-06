using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ControllerMovement : MonoBehaviour
{
    public float moveSpeed;
    public float rotationAngle = 45f;
    public float rotationLerpSpeed = 5f;
    public string horizontalAxisName = "Horizontal";
    public string verticalAxisName = "Vertical";
    public string rotateAxisName = "Rotate";
    Rigidbody rigidBody;
    private float targetRotation;
    private float currentRotationVelocity;
    public GameObject mainCamera;
    CharacterController cc;


    void Awake()
    {
        rigidBody= GetComponent<Rigidbody>();
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
        cc.SimpleMove(movement * moveSpeed);
        movement.y = rigidBody.velocity.y;
        //rigidBody.velocity = movement * moveSpeed;
    }

    void PlayerRotate()
    {
        float rotationInput = Input.GetAxis(rotateAxisName);
        //float rotationAmount = rotationInput * rotationSpeed * Time.fixedDeltaTime;
        //transform.Rotate(Vector3.up, rotationAmount);

        if(rotationInput != 0)
        {
            int rotationSteps = Mathf.RoundToInt(rotationInput);
            targetRotation = Mathf.Round(targetRotation / rotationAngle) * rotationAngle + rotationSteps * rotationAngle;
        }

        float newRotation = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetRotation, ref currentRotationVelocity, rotationLerpSpeed * Time.deltaTime);
        transform.rotation = Quaternion.Euler(0, newRotation, 0);
    }

    void PlayerCCRotate()
    {
        transform.Rotate(0, Input.GetAxis(rotateAxisName) * rotationLerpSpeed, 0);
    }
}
