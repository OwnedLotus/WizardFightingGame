using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{

    public CharacterController characterController;
    public Transform playerTransform;


    public float jumpForce = 10f;
    public float baseSpeedMultiplyer = 1f;
    public float runSpeedMultiplyer = 1f;
    public float gravityStrength = 1f;
    public float mouseAcceleration = 1f;
    

    private float moveX, moveZ, verticalMovement, mouseHorizontal, mouseVertical;
    private float runSpeed = 1f;
    private Vector3 moveSpeed;
    private Quaternion currentRotation, lookAt;
    

    
    // Start is called before the first frame update
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        playerTransform = GetComponent<Transform>();
    }

    void FixedUpdate()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveZ = Input.GetAxisRaw("Vertical");
        

        Debug.Log("mX = " + moveX.ToString());
        Debug.Log("mZ = " + moveZ.ToString());

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


        moveSpeed = new Vector3(moveX * baseSpeedMultiplyer * runSpeed, verticalMovement, moveZ * baseSpeedMultiplyer * runSpeed);
        characterController.Move(moveSpeed);

        
        mouseHorizontal = Input.GetAxisRaw("Mouse X");
        mouseVertical = Input.GetAxisRaw("Mouse Y");

        currentRotation = playerTransform.rotation;
        Quaternion targetRotation = Quaternion.Euler(moveSpeed.x, moveSpeed.y, 0f);

        lookAt = Quaternion.Lerp(currentRotation, targetRotation, mouseAcceleration);

        playerTransform.rotation = Quaternion.RotateTowards(currentRotation,lookAt,360);
        

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