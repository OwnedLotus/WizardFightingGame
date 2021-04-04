using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public int jumpMax, topSpeed;
    private int jump = 0;
    Vector3 move;
    public Vector3 jumpForce;
    public Transform rayStart;
    RaycastHit hit;
    private float mHorizontal, mForward;
    bool isGrounded = false;

    // Start is called before the first frame update
 void Awake() 
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        mHorizontal = Input.GetAxisRaw("Horizontal");
        mForward = Input.GetAxisRaw("Vertical");

        move = new Vector3(mHorizontal, 0, mForward);
        rb.AddForce(move);
        
        if (isGrounded)
        {
            jump = jumpMax;
        }

        if (Input.GetKey(KeyCode.Space) && jump != 0)
        {
            if (!isGrounded)
            {
                jump--;
            }

            jumpForce = new Vector3(0f, 50f, 0f);
            rb.AddForce(jumpForce);
        }
    }

    private void Update() 
    {
        
        
        
    }

    /*          For later Flying super maybe
    private bool Jump(RaycastHit hit)
    {
        
        if (Physics.Raycast(rayStart.position, -transform.up, out hit, 1f))
        {
            isGrounded = true;
        }

        return isGrounded;
    }
    */

    private void OnCollisionEnter(Collision other) 
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            print("Grounded");
        }
    }

    private void OnCollisionExit(Collision other) 
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            print("Not Grounded");
        }
    }
}
