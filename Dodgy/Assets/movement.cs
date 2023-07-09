using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class movement : MonoBehaviour
{
    // Animator animator;
    public float horizontalMove;
    public int speed = 4;
    public int jumpAmount = 20;
    public float verticalMove;
    public float cameraAngle;
    private Rigidbody rb;
    // public float radius = 0.00001f;
    // public GroundCheck groundCheck;

    // Start is called before the first frame update
    void Start()
    {
        // animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();

    }

    bool isGrounded()
    {
        RaycastHit hit;
        float distance = 0.50f;
        Vector3 dir = new Vector3(0, -1);

        return Physics.Raycast(transform.position, dir, out hit, distance);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bool isWalkingHorizontal = Input.GetButton("Horizontal");
        bool isWalkingVertical = Input.GetButton("Vertical");
        bool jumpPressed = Input.GetButton("Jump");

        if (isWalkingHorizontal || isWalkingVertical)
        {
            horizontalMove = Input.GetAxis("Horizontal") * Time.deltaTime * 150;
            verticalMove = Input.GetAxis("Vertical") * Time.deltaTime * 150;

            cameraAngle = Camera.main.transform.localEulerAngles.y;

            Quaternion myRotation = Quaternion.Euler(0, cameraAngle, 0);

            Vector3 movement = new Vector3(horizontalMove, 0, verticalMove);

            Vector3 rotatedMovement = myRotation * movement;

            rb.AddForce(rotatedMovement * speed);
            
            // animator.SetBool("isWalking", true);
            

            // transform.Rotate(0, horizontalMove, 0);

            // transform.Translate(0, 0, verticalMove * 5);
            // transform.localEulerAngles = new Vector3(0, transform.localRotation.eulerAngles.y, 0);


        }
        else
        {
            //animator.speed = 1;
            //animator.SetBool("isWalking", false);
            
        }

        if (jumpPressed && isGrounded())
        {
            rb.AddForce(Vector2.up * jumpAmount);
        }
    }


}
