using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public int jumpMaxNU, topSpeedNU; //Not Utilized behavior
    private int jump = 0;
    Vector3 move;
    public Vector3 jumpForce;
    public Transform rayStart;
    RaycastHit hit;
    private float mHorizontal, mForward;
    bool isGrounded = false;
    public Transform player;
    public float mouseSpeed = 3f;
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

        move = new Vector3(mHorizontal * speed, 0, mForward * speed);
        rb.AddForce(move);
        
        
        if(isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                jumpForce = new Vector3(0f, 50f, 0f);
                rb.AddForce(jumpForce);
            }
        }
        //FacePlayer();
    }

   /* private void FacePlayer() 
    {
        rb.transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(move), 0.15f);
        
        
    }*/

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
            //print("Grounded");
        }
    }

    private void OnCollisionExit(Collision other) 
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            //print("Not Grounded");
        }
    }
}
