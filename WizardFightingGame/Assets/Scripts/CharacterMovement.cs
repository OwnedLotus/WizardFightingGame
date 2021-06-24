using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public CharacterController characterController;
    public float jumpForce = 10f;
    public float baseSpeedMultiplyer = 1f;
    public float runSpeedMultiplyer = 1f;
    public float gravityStrength = 1f;
    private float mX, mZ, verticalMovement;
    private float runSpeed = 1f;
    private Vector3 moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void FixedUpdate()
    {
        mX = Input.GetAxis("Horizontal");
        mZ = Input.GetAxis("Vertical");

        Debug.Log("mX = " + mX.ToString());
        Debug.Log("mZ = " + mZ.ToString());

        if (characterController.isGrounded == true)
        {
            if (Input.GetKeyDown("space"))
            {
                Debug.Log("Jumped!");
                verticalMovement = jumpForce;
            }
        }
        else
        {
            Debug.Log("AirBorne");
            verticalMovement = -gravityStrength;
        }


        moveSpeed = new Vector3(mX * baseSpeedMultiplyer * runSpeed, verticalMovement, mZ * baseSpeedMultiplyer * runSpeed);
        characterController.Move(moveSpeed);

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