using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    [SerializeField] private float playerSpeed = 5.0f;

    public float jumpHeight = 5.0f;

    public int numberJumps = 1;

    private CharacterController controller;

    public static float verticalVelocity;
    [SerializeField] private float gravity = 14.0f;
    [SerializeField] private float jumpForce = 10.0f;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        respawn = GetComponent<Transform>();
    }

    private void JumpMechanic()
    {
        if (controller.isGrounded)
        {
            numberJumps = 1;

            if (numberJumps != 0)
            {
                verticalVelocity = -gravity * Time.deltaTime;
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    numberJumps = 0;
                    verticalVelocity = jumpForce;
                }
            }
        }
        else
        {
            verticalVelocity -= gravity * Time.deltaTime;
        }
    }

    private void HorizontalMovement()
    {
        //Provides the movement on the Z axis for the Player
        Vector3 moveVector = Vector3.zero;
        moveVector.y = verticalVelocity;
        moveVector.z = Input.GetAxis("Horizontal") * playerSpeed;
        controller.Move(moveVector * Time.deltaTime);
    }

    void Update()
    {
        HorizontalMovement();
        JumpMechanic();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        //Resupply the number of jumps the player has once it touches the floor or an arrow
        if(collision.gameObject.tag == "Floor")
        {
            numberJumps = 1;
        }
        if (collision.gameObject.tag == "StuckArrow")
        {
            numberJumps = 1;
        }
    }


    //Player Respawn
    public Transform respawnPoint;
    Transform respawn;
    private void OnTriggerEnter(Collider other)
    {
        controller.enabled = false;
        verticalVelocity = 0f;

        if (other.gameObject.tag == "SpikeObject")
        {
            respawn.position = respawnPoint.transform.position;
            controller.enabled = true;

        }
        if (other.gameObject.tag == "ArrowPickup")
        {
            Debug.Log("Picked up arrow");
            controller.enabled = true;
        }
        if (other.gameObject.tag == "RespawnSet")
        {
            controller.enabled = true;
        }
    }
}
