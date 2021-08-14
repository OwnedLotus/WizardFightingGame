using UnityEngine;

public class CharaterMovement : MonoBehaviour
{
    CharacterController playerController;
    Rigidbody playerRB;
    Transform playerTr;

    float jumpForce = 10f;
    float baseSpeedMultiplyer = 1f;
    float runSpeedMultiplyer = 1f;
    float gravityMultiplyer = 1f;
    float mouseAccelMultiplyer = 1f;

    private float moveX, moveZ;
    private float verticalMovement;
    private float moveHorizontal, moveVertical;
    private float runSpeed = 1f;

    private Vector3 moveSpeed;
    private Quaternion currentRotation, lookAt;

    private void Awake()
    {
        playerController = GetComponent<CharacterController>();
        playerRB = GetComponent<Rigidbody>();
        playerTr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        moveX = Input.GetAxisRaw("Horizontal");
        moveZ = Input.GetAxisRaw("Vertical");
        moveHorizontal = Input.GetAxisRaw("Mouse X");
        moveVertical = Input.GetAxisRaw("Mouse Y");


        if (playerController.isGrounded == true)
        {
            if (Input.GetButton("Space"))
            {
                Jump();
            }
        }

        moveSpeed = new Vector3(moveX * baseSpeedMultiplyer * runSpeedMultiplyer, 0, moveZ * baseSpeedMultiplyer * runSpeedMultiplyer);

        playerController.Move(moveSpeed * Time.deltaTime);
    }

    float Jump()
    {
        float jump = 0;


        return jump;
    }

    void SpellCast()
    {

    }
}
