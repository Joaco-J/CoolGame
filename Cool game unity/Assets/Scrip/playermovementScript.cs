//code from Brackeys//
// https://www.youtube.com/watch?v=_QajrabyTJc&t=4s //


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermovementScript : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 12f;

    Vector3 velocity;
    public float gravity = -9.81f;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;
    bool isGrounded;

    public float jump = 3f;

    // Update is called once per frame
    private void FixedUpdate()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        //invtory[32] =
        other.gameObject.GetComponent<pickUp>().item;
        Destroy(other.gameObject);
    }
    void Update()
    {
        isGrounded =Physics.CheckSphere(groundCheck.transform.position, groundDistance, groundMask);
        

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward*z;

        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGrounded)
        {       
            velocity.y = Mathf.Sqrt(jump * -2f * gravity);
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);

    }

}
