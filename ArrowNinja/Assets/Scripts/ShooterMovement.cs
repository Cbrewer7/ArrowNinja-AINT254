using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterMovement : MonoBehaviour
{
    Rigidbody rb;
    public float shooterSpeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //The Objective of this is to get the movement with the arrow keys
        //and not have the player object move with the same input
        if (Input.GetKey("left"))
        {
            rb.velocity = new Vector3(0, 0, -10);
        }
        else if (Input.GetKey("right"))
        {
            rb.velocity = new Vector3(0, 0, 10);
        }
        else if (Input.GetKey("up"))
        {
            rb.velocity = new Vector3(0, 10, 0);
        }
        else if (Input.GetKey("down"))
        {
            rb.velocity = new Vector3(0, -10, 0);
        }
        else
        {
            rb.velocity = new Vector3(0, 0, 0);
        }
        
        //transform.Translate(Input.GetAxis("Horizontal1"), 0, 0 * Time.deltaTime * shooterSpeed);
        //transform.Translate(0, Input.GetAxis("Vertical1"), 0 * Time.deltaTime * shooterSpeed);
        //rb.AddForce(new Vector3(0, 0, 0), ForceMode.Impulse);
    }
}
