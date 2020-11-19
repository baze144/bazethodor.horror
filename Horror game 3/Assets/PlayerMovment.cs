using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovment : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;
    public float sprint = 18f;
    public float gravity = -9.23f;
    public float jumpHeight = 3f;

    public Transform GroundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;    
    
    Vector3 velocity;
    bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGround = Physics.CheckSphere(GroundCheck.position, groundDistance, groundMask);

        if(isGround && velocity.y < 0)
        {
                
            velocity.y = -2f;
        }

        if (Input.GetButtonDown("Jump") && isGround) {

            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);
        
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {

            speed = sprint;

        }
        else {

            speed =12f;
        }
        float x = Input.GetAxis("Horizontal");
        float z= Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);

    }
}
