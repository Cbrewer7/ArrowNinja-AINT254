using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rb;

    public float playerSpeed = 5.0f;

    public float jumpHeight = 5.0f;

    public int numberJumps = 1;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Player can move left to right on a single axis
        transform.Translate(0, 0, Input.GetAxis("Horizontal") * Time.deltaTime * playerSpeed);

        
        if(numberJumps != 0)
        {
            // Player can jump using spacebar
            if (Input.GetKeyDown(KeyCode.Space))
            {
                numberJumps = 0;
                rb.AddForce(new Vector3(0, jumpHeight, 0), ForceMode.Impulse);
            }
        }  
    }

    private void OnCollisionEnter(Collision collision)
    {
        //Resupply the number of jumps the player has once it touches the floor or an arrow
        if(collision.gameObject.tag == "Floor")
        {
            numberJumps = 1;
        }
        if (collision.gameObject.tag == "Arrow")
        {
            numberJumps = 1;
        }
    }
}
