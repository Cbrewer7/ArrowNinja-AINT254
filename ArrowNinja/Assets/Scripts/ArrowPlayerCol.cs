using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowPlayerCol : MonoBehaviour
{
    Rigidbody rb;

    CharacterController controller;

    private float verticalVelocity;
    private float jumpforce = 5.0f;
    private float gravity = 14.0f;

    PhysicMaterial bounce;

    private void Update()
    {
        rb = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
        bounce = GetComponent<PhysicMaterial>();
    }

    private void OnCollisionEnter(Collision collision)
    {

        //if(collision.gameObject.tag == "Arrow")
        //{
        //    bounce.bounciness = 0.8f;
        //}
        //else
        //{
        //    bounce.bounciness = 0f;
        //}

        //if (controller.isGrounded)
        //{
        //    //verticalVelocity = -gravity * Time.deltaTime;
        //    Vector3 vertVel = controller.velocity;
        //    if (collision.gameObject.tag == "Arrow")
        //    {
        //        vertVel = new Vector3(controller.velocity.x, jumpforce, controller.velocity.z);
        //        //verticalVelocity = jumpforce;
        //        rb.AddForce(Vector3.up * jumpforce);
        //    }
        //}
    }
}
