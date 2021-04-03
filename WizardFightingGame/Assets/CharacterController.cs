using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public int jumpNum, topSpeed;
    Vector3 move;
    public Vector3 jumpForce;
    public Transform rayStart;
    RaycastHit hit;
    private float mHorizontal, mForward;

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
    }

    private void Update() 
    {
        
        Jump(hit);
        
    }

    private void Jump(RaycastHit hit)
    {
        if (Physics.Raycast(rayStart.position, -transform.up, out hit, 1f))
        {
            print("isGrounded");
        }
    }

    
}
