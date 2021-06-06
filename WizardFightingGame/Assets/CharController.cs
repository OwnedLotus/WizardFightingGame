using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

[RequireComponent(typeof(CharacterController))]
public class CharController : MonoBehaviour
{
    CharacterController CharacterController;
    public float jumpForce = 10f;
    public float baseSpeedMultiplyer = 1f;
    public float runSpeedMultiplyer = 1f;
    public float gravityStrenth = 0f;
    private float mX, mZ;
    private Vector3 moveSpeed;
    private float jump;

    private bool isGrounded = false;

    public Transform playerBody;
    private Vector2 mouseMovement;

    public CinemachineInputAxisDriver xAxis;
    public CinemachineInputAxisDriver yAxis;

    private CinemachineFreeLook freeLook;

    private void Awake()
    {
        
        freeLook = GetComponent<CinemachineFreeLook>();
        freeLook.m_XAxis.m_MaxSpeed = freeLook.m_XAxis.m_AccelTime = freeLook.m_XAxis.m_DecelTime = 0;
        freeLook.m_XAxis.m_InputAxisName = string.Empty;
        freeLook.m_YAxis.m_MaxSpeed = freeLook.m_YAxis.m_AccelTime = freeLook.m_YAxis.m_DecelTime = 0;
        freeLook.m_YAxis.m_InputAxisName = string.Empty;
    }

    private void OnValidate()
    {
        xAxis.Validate();
        yAxis.Validate();
    }

    private void Reset()
    {
        xAxis = new CinemachineInputAxisDriver
        {
            multiplier = -10f,
            accelTime = 0.1f,
            decelTime = 0.1f,
            name = "Mouse X",
        };
        yAxis = new CinemachineInputAxisDriver
        {
            multiplier = 0.1f,
            accelTime = 0.1f,
            decelTime = 0.1f,
            name = "Mouse Y",
        };
    }

    // Start is called before the first frame update
    void Start()
    {
        CharacterController = GetComponent<CharacterController>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void FixedUpdate()
    {
        mX = Input.GetAxisRaw("Horizontal");
        mZ = Input.GetAxisRaw("Vertical");

        //Debug.Log("mX = " + mX.ToString());
        //Debug.Log("mZ = " + mZ.ToString());


        /*   not working
        while (Input.GetKeyDown(KeyCode.LeftShift)) 
        {
            moveSpeed = new Vector3(mX * baseSpeedMultiplyer * runSpeedMultiplyer * Time.deltaTime, -gravityStrenth, mZ * baseSpeedMultiplyer * runSpeedMultiplyer * Time.deltaTime);
        }
        */

        

        

        if (CharacterController.isGrounded)
        {
            //Debug.Log("Grounded");
            if (Input.GetKey(KeyCode.Space))
            {
                //Debug.Log("Jumped");
                jump = jumpForce;
            }
        }

        moveSpeed = new Vector3(mX * baseSpeedMultiplyer,jump * -gravityStrenth, mZ * baseSpeedMultiplyer);

        CharacterController.Move(moveSpeed * Time.deltaTime);


        bool changed = yAxis.Update(Time.deltaTime, ref freeLook.m_YAxis);
        changed |= xAxis.Update(Time.deltaTime, ref freeLook.m_XAxis);
        if (changed)
        {
            freeLook.m_RecenterToTargetHeading.CancelRecentering();
            freeLook.m_YAxisRecentering.CancelRecentering();
        }

    }

    /*          For later Flying spell maybe
        private bool Jump(RaycastHit hit)
        {

            if (Physics.Raycast(rayStart.position, -transform.up, out hit, 1f))
            {
                isGrounded = true;
            }

            return isGrounded;
        }
    */
}   