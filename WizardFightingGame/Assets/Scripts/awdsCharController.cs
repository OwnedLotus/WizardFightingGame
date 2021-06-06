/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[RequireComponent(typeof(CharacterController))]
public class CharController : MonoBehaviour
{
    CharacterController ch;
    public float speed;
    public int jumpMaxNU, topSpeedNU; //Not Implemented
    private int jump = 0;
    Vector3 move;
    public Vector3 jumpForce;
    public Transform rayStart;
    RaycastHit hit;
    private float mHorizontal, mForward;
    //bool isGrounded = false;
    public Transform player;
    public float mouseSpeed = 3f;

    // Start is called before the first frame update
    void Awake() 
    {
        ch = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        mHorizontal = Input.GetAxis("Horizontal");
        mForward = Input.GetAxis("Vertical");
        move = new Vector3(mHorizontal * speed, -10, mForward * speed);

       // Debug.Log("Horizontal Movement : " + mHorizontal.ToString());
       // Debug.Log("Forward Movement : " + mForward.ToString());

        if(isGrounded)
        {
            if (Input.GetKey(KeyCode.Space))
            {
             //   Debug.Log("Grounded: " + isGrounded.ToString());
                jumpForce = new Vector3(0f, 50f, 0f);
                ch.Move(jumpForce);
            }
        }


        ch.Move(move);
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
*/